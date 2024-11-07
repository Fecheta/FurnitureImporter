# Use the official Node.js image as base
FROM node:18 AS build

# Set working directory
WORKDIR /usr/src/app

# Copy package.json and install dependencies
COPY package*.json ./
RUN npm install

# Copy the rest of the application
COPY . ./

# Build the Angular app
RUN npm run build --prod

# Use the official Nginx image to serve the Angular app
FROM nginx:alpine

# Copy the built Angular app to Nginx's html folder
COPY --from=build /usr/src/app/dist/Frontend /usr/share/nginx/html


FROM mcr.microsoft.com/dotnet/sdk:8.0@sha256:35792ea4ad1db051981f62b313f1be3b46b1f45cadbaa3c288cd0d3056eefb83 AS build-env
WORKDIR /App

# Copy everything
COPY . ./
# Restore as distinct layers
RUN dotnet restore

# Install Node.js and npm (required for npm run build)
RUN apt-get update && apt-get install -y \
    nodejs \
    npm

# Build and publish a release
RUN dotnet publish -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:8.0@sha256:6c4df091e4e531bb93bdbfe7e7f0998e7ced344f54426b7e874116a3dc3233ff
WORKDIR /App
COPY --from=build-env /App/out .
ENTRYPOINT ["dotnet", "FurnitureImporter.dll"]