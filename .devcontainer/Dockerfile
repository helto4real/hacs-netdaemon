FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster

# This Dockerfile adds a non-root 'vscode' user with sudo access. However, for Linux,
# this user's GID/UID must match your local user UID/GID to avoid permission issues
# with bind mounts. Update USER_UID / USER_GID if yours is not 1000. See
# https://aka.ms/vscode-remote/containers/non-root-user for details.
ARG USERNAME=vscode
ARG USER_UID=1000
ARG USER_GID=$USER_UID

# [Optional] Version of Node.js to install.
ARG INSTALL_NODE="false"
ARG NODE_MAJOR_VERSION="10"

# [Optional] Install the Azure CLI
ARG INSTALL_AZURE_CLI="false"

ENV TZ=Europe/Stockholm

# Avoid warnings by switching to noninteractive
ENV DEBIAN_FRONTEND=noninteractive

# Configure apt and install packages
RUN apt-get update \
    && apt-get -y install dialog git iproute2 procps 2>&1
# Switch back to dialog for any ad-hoc use of apt-get
ENV DEBIAN_FRONTEND=noninteractive