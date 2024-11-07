
Here’s the revised text reflecting that the Angular app is integrated but not deployed on the server:

The project is built using Hexagonal Architecture, designed to support a microservices approach. All components are decoupled through the use of interfaces, and data is hardcoded, with no database used.

The server is deployed on Google Cloud using a Docker image stored in the Container Registry and run via Cloud Run. The implementation includes customers, furniture items, and a strategy for calculating discounted prices for each customer.

An Angular frontend is integrated but is not deployed on the server; currently, only the server API is accessible.

  - Url to get all customers: [https://furniture-importer01-616383822447.us-central1.run.app/FurnitureImporter/GetAllCustumers](https://furniture-importer01-616383822447.us-central1.run.app/FurnitureImporter/GetAllCustumers)
  - Url to get all furnitures: [https://furniture-importer01-616383822447.us-central1.run.app/FurnitureImporter/GetAllFurnitures](https://furniture-importer01-616383822447.us-central1.run.app/FurnitureImporter/GetAllFurnitures)
  - Url to get the discount: [https://furniture-importer01-616383822447.us-central1.run.app/FurnitureImporter/f4c1908f-6437-4965-b692-d07078b5d070/GetDiscountedPriece/b14b537b-85e0-4b59-b674-ee0647ef491a]
