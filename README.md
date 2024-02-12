# tp-exercise

**Objective:**

Create a simple, scalable, and resilient web application deployment pipeline using Azure, Azure DevOps, and Kubernetes. This exercise is designed to demonstrate your ability to automate the build and deployment processes, manage containerized applications..


**Requirements:**

1. **Application Setup:**

   - Develop a basic web application in C# (ASP.NET Core) that displays a simple "Hello, World!" message on the homepage.
	> **Note**: A templated ASP.NET Core Web App (MVC) using the .NET 8.0 Framework was choosen for simplicity.
2. **Containerization:**

   - Dockerize the web application, ensuring it can be run as a container.
   > **Note**: A templated Dockerfile was generated to containerize the application, which pins to to a specific .NET SDK version, uses multi-stage build to reduce image size, and runs the container under a non root user for security purposes.

3. **CI/CD Pipeline:**

   - Set up a CI/CD pipeline in Azure DevOps that automates the building of the Docker image and pushing it to a container registry.  Azure Container Registry (ACR) is preferred but may have a small cost associated with it. Dockerhub can be used for free as an alternative to ACR if desired.

   - The CI process should trigger on every commit to the main branch.

   - The CD process should deploy the latest Docker image to a Kubernetes cluster hosted on Azure (AKS).
    > **Note**: A CI/CD pipeline for Azure Devops was created and ran(ci-cd-aks-deploy-pipleine.yml). The pipeline is triggered on any code changes pushed to the main branch where the docker image is built, stored in an ACR registry and then deploys the 'latest' image to the AKS cluster.

4. **Kubernetes Deployment:**

   - Create Kubernetes deployment and service YAML files for the web application.
   > **Note**: A 'manifests' folder was created in the root directory that contains all the kubernetes files that were created for this deployment.
   - Ensure the deployment is resilient. Consider using readiness and liveness probes.
   > **Note**: In order to create a more scalable and resilient deployment, readiness(health/ready) and liveness(/health/live) probes were implemented, resource requests/limits were set, replica count was set to 2, pod anti-affinity to schedule pods to seperate nodes, horizontal pod auto scaling was configured, along with a pod disruption budget was applied.


5. **K8s Cluster**

- Stand up an aks cluster and deploy to it using everything from the above steps.

- If there are concerns about the costs of this, please let me know and we can work something out.
> **Note**: The AKS cluster was setup with the 'Free' SKU, and was setup with 3 availability zones in order to help with implementation of application resilency tactics.






