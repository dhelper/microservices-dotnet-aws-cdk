﻿// Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
// SPDX-License-Identifier: MIT-0
using Amazon.CDK;

namespace InfraSampleWebApp
{
    sealed class Program
    {
        public static void Main(string[] args)
        {
            var app = new App();
            _ = new InfraStackDemo(app, "WebAppInfraStack", new StackProps
            {
                // If you don't specify 'env', this stack will be environment-agnostic.
                // Account/Region-dependent features and context lookups will not work,
                // but a single synthesized template can be deployed anywhere.

                // Uncomment the next block to specialize this stack for the AWS Account
                // and Region that are implied by the current CLI configuration.
                /*
                Env = new Amazon.CDK.Environment
                {
                    Account = System.Environment.GetEnvironmentVariable("CDK_DEFAULT_ACCOUNT"),
                    Region = System.Environment.GetEnvironmentVariable("CDK_DEFAULT_REGION"),
                }
                */

                // Uncomment the next block if you know exactly what Account and Region you
                // want to deploy the stack to.
                /*
                Env = new Amazon.CDK.Environment
                {
                    Account = "123456789012",
                    Region = "us-east-1",
                }
                */

                // For more information, see https://docs.aws.amazon.com/cdk/latest/guide/environments.html
            });

            // new InfraMultiTaskStack(app, nameof(InfraMultiTaskStack), new StackProps{

            // });

            app.Synth();
        }
    }
}
