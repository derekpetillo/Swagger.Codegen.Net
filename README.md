# Swagger.Codegen.Net [![Build status](https://ci.appveyor.com/api/projects/status/qay2eigrfqkmc2qy/branch/master)](https://ci.appveyor.com/project/TimSchlechter/swagger-codegen-net/branch/master)

Commandline tool which generates client code for a [Swagger](https://helloreverb.com/developers/swagger) enabled API

```
swagger.exe [options]
```

This repository tries to provide the same functionality offered by the awesome [swagger-codegen](https://github.com/wordnik/swagger-codegen) but without its [Prerequisites](https://github.com/wordnik/swagger-codegen#prerequisites) (which might be a bit inconvenient in a .Net environment ;-))

## Options

| Option              | Description                                                                                                                                                                                            |
| ------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| -u,<br/>--url       | The url of the API which serves the resource listing                                                                                                                                                   |
| -a,<br/>--apiname   | The name of the API                                                                                                                                                                                    |
| -n,<br/>--namespace | Specifies the namespace for the generated proxy or template. The default namespace is the global namespace.                                                                                            |
| -o,<br/>--out       | Specifies the file (or directory) in which to save the generated proxy code. You can also specify a directory in which to create this file. The tool derives the default file name from the API name.  |

## Examples

```
swagger.exe --url "http://petstore.swagger.wordnik.com/api/api-docs" --apiname PetStore
```

