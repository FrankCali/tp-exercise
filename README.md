# tp-exercise

**Objective:**

Create a simple, scalable, and resilient web application deployment pipeline using Azure, Azure DevOps, and Kubernetes. This exercise is designed to demonstrate your ability to automate the build and deployment processes, manage containerized applications..


**Requirements:**

1. **Application Setup:**

   - Develop a basic web application in C# (ASP.NET Core) that displays a simple "Hello, World!" message on the homepage.
	> **Note**: A templated ASP.NET Core Web App (MVC) using the .NET 8.0 Framework was choosen for simplicity.
2. **Containerization:**

   - Dockerize the web application, ensuring it can be run as a container.


3. **CI/CD Pipeline:**

   - Set up a CI/CD pipeline in Azure DevOps that automates the building of the Docker image and pushing it to a container registry.  Azure Container Registry (ACR) is preferred but may have a small cost associated with it. Dockerhub can be used for free as an alternative to ACR if desired.

   - The CI process should trigger on every commit to the main branch.

   - The CD process should deploy the latest Docker image to a Kubernetes cluster hosted on Azure (AKS).


4. **Kubernetes Deployment:**

   - Create Kubernetes deployment and service YAML files for the web application.

   - Ensure the deployment is resilient. Consider using readiness and liveness probes.
	>**Note**: The following healthchecks were implemented
	>Readiness Path: /health/ready
	>Liveness Path: /health/live

5. **K8s Cluster**

- Stand up an aks cluster and deploy to it using everything from the above steps.

- If there are concerns about the costs of this, please let me know and we can work something out.


6. **Documentation:**

   - Provide a README file with detailed instructions on how to set up and run the pipeline, including any prerequisites.

   - Document any assumptions you've made and choices in your deployment strategy.



**Deliverables:**

- Source code for the web application and Dockerfile.

- YAML files for Kubernetes deployment and service.

- Azure DevOps pipeline definitions (YAML or via the Azure DevOps UI, with export if applicable).

- A README file with setup and deployment instructions.