#!/bin/sh
dotnet test --filter "FullyQualifiedName~\"$1\"|DisplayName=\"$1\""
