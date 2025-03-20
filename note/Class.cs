using Microsoft.VisualBasic;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics.Metrics;
using System.Text.RegularExpressions;
using System.Threading.Channels;
using System;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Hosting;
using System.Buffers.Text;
using System.Diagnostics;
using System.IO;
using static System.Net.Mime.MediaTypeNames;
using System.Net.Sockets;
using System.Numerics;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Options;

namespace LearnCICD.note
{
    public class Class
    {

        //What is CI/CD?

        //CI/CD stands for Continuous Integration(CI) and Continuous Deployment(CD). It is a set of best practices in DevOps that helps automate software development and deployment.

        //Continuous Integration (CI): Developers frequently merge their code changes into a shared repository (e.g., GitHub, GitLab, Azure DevOps). The code is automatically built and tested to detect errors early.

        //Continuous Deployment (CD): After successful testing, the code is automatically deployed to production without manual intervention.

        //Continuous Delivery: A middle ground where changes are deployed to a staging environment but require manual approval before going live.

        //Why CI/CD is Important?

        //Reduces manual deployment errors

        //Speeds up the software release cycle

        //Ensures better software quality with automated testing

        //Helps maintain a stable and reliable production environment

        //2️ Version Control & Branching Strategies

        //Before implementing CI/CD, you need to use a version control system(VCS) like Git, which allows multiple developers to collaborate on a project.

        //Branching Strategies in CI/CD
        //A well-structured branching strategy ensures smooth integration and deployment:

        //1. GitFlow (Best for large teams)

        //main(stable production-ready branch)

        //develop(integrates new features)

        //feature (new features in development)

        //hotfix (urgent fixes for production)

        //2. Trunk-Based Development (Best for fast releases)

        //No long-lived branches, frequent merges into main

        //Small, frequent deployments with feature flags

        //3. GitHub Flow(Simplified workflow)

        //Only two branches: main and feature/*

        //Merge to main after approval and deploy immediately

        //3️⃣ CI/CD Tools & Platforms
        //Different tools help automate the CI/CD process.The choice depends on the tech stack and requirements.

        //Popular CI/CD Tools
        //Tool Description
        //Jenkins => Open-source, highly customizable CI/CD tool
        //GitHub Actions =>  CI/CD automation for GitHub repositories
        //GitLab CI/CD => Integrated directly into GitLab
        //Azure DevOps Pipelines =>  Microsoft's CI/CD platform for cloud-native apps
        //CircleCI => Fast and easy-to-configure CI/CD
        //Travis CI => Cloud-based CI/CD tool for open-source projects

        //Each tool allows automated builds, testing, and deployment to staging or production environments.

        //4️⃣ Setting Up CI/CD Pipelines
        //A CI/CD pipeline is an automated sequence of processes that code changes go through before reaching production.

        //CI/CD Pipeline Stages
        //1. Source Code Management

        //Code is pushed to a repository(GitHub, GitLab, Azure DevOps).

        //2. Build Stage

        //Code is compiled and dependencies are installed.

        //Example: .NET build, npm install, docker build.

        //3. Testing Stage

        //Unit tests, integration tests, and security scans are run.

        //4. Deployment Stage

        //The application is deployed to staging/production environments.

        //5. Monitoring & Alerts

        //Performance monitoring tools check system health.

        //Example: GitHub Actions CI/CD Pipeline (YAML)

        //You can test all these CI/CD pipelines on your local machine before deploying them to cloud services. Here’s how to set up and run each pipeline locally:


        //Steps to Set Up Your Docker Token
        //1. Go to Docker Hub

            /*  .Open Docker Hub
            .Navigate to Account Settings → Security
            .Click New Access Token and generate a new token.

           2. Store Token in GitHub Secrets

            .Go to your GitHub repository → Settings → Secrets and variables → Actions
            .Click New repository secret

            Add:
            DOCKER_USERNAME → Your Docker Hub username
            DOCKER_TOKEN → The generated token
            ** Push a Test Commit*/
    }
}
