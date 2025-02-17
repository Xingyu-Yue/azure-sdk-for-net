# Release History

## 1.1.0-beta.1 (Unreleased)

### Features Added
- Upgrade to 2022-11-01-preview api version
- Add API to start, stop and executions for ContainerAppJobs
- Support keyvault for container app secret
- Add managedBy for ContainerApps
- Add keda/dapr version support
- Add API to support ManagedCertificate
- Add AppState and LatestReadyRevisionName
- Add Client certificate mode for mTLS authentication and corsPolicy for Container App
- Add Friendly workload profile name support

### Bugs Fixed
- Fix certifaicte password format for environment custom domain

### Other Changes

## 1.0.3 (2023-03-28)

### Bugs Fixed

- Property `RegistryUri` in class `ContainerAppRegistryInfo` is now obsoleted, please use `RegistryServer` instead.

### Other Changes

- Upgraded dependent `Azure.Core` to `1.30.0`.

## 1.0.2 (2023-02-21)

### Other Changes

- Upgraded dependent `Azure.Core` to `1.28.0`.
- Upgraded dependent `Azure.ResourceManager` to `1.4.0`.

## 1.0.1 (2022-12-27)

### Bugs Fixed

- Fix the incorrect format of the `ContainerAppData.OutboundIPAddresses` by deprecating this property and adding new property `ContainerAppData.OutboundIPAddressList`.

## 1.0.0 (2022-12-23)

This is the first stable release of the AppContainers Management library.

### Features Added

- Upgraded API version to 2022-10-01.

### Breaking Changes

Polishing since last public beta release:
- Prepended `ContainerApp` prefix to all single / simple model names.
- Corrected the format of all `ResourceIdentifier` type properties / parameters.
- Corrected the format of all `IPAddress` type properties / parameters.
- Optimized the name of some models and functions.

## 1.0.0-beta.1 (2022-07-12)

### Breaking Changes

- Change the namespace from `Azure.ResourceManager.Applications.Containers` to `Azure.ResourceManager.AppContainers`.

### General New Features

This package follows the [new Azure SDK guidelines](https://azure.github.io/azure-sdk/general_introduction.html), and provides many core capabilities:

    - Support MSAL.NET, Azure.Identity is out of box for supporting MSAL.NET.
    - Support [OpenTelemetry](https://opentelemetry.io/) for distributed tracing.
    - HTTP pipeline with custom policies.
    - Better error-handling.
    - Support uniform telemetry across all languages.

This package is a Public Preview version, so expect incompatible changes in subsequent releases as we improve the product. To provide feedback, submit an issue in our [Azure SDK for .NET GitHub repo](https://github.com/Azure/azure-sdk-for-net/issues).

> NOTE: For more information about unified authentication, please refer to [Microsoft Azure Identity documentation for .NET](https://docs.microsoft.com//dotnet/api/overview/azure/identity-readme?view=azure-dotnet).

