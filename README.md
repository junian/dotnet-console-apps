<div align="center">

<img src="https://raw.githubusercontent.com/junian/commons-media/refs/heads/master/svg/microsoft-dotnet-logo.svg" height="128px" />

# .NET Console Apps

A collection of .NET console apps and scripts

</div>

## About

This is a special repository to celebrate `dotnet run app.cs`, where you can just use a single C# file to run the script.

You need [.NET 10 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/10.0) installed.

Read example guide [here](https://www.junian.dev/tech/dotnet-run-csharp-app/).

## Content

| Project Name | Code | Post  |
|--------------|------|-------|
| Hello, World!                    | [Source Code](./src/hello-world/) | [Guide](https://www.junian.dev/tech/dotnet-run-csharp-app/)       |
| Year 2038 Problem                | [Source Code](./src/year-2038-problem/) | [Guide](https://www.junian.dev/tech/dotnet-run-csharp-app/) |
| ASP.NET Server Time              | [Source Code](./src/aspdotnet-server-time/) | [Guide](https://www.junian.dev/tech/dotnet-run-csharp-app/) |
| String Hash in C# (MD5 / SHA-256 / SHA-384 / SHA-512) | [Source Code](./src/string-hasher/) | [Guide](https://www.junian.dev/tech/csharp-string-hash/) |
## Executable PATH

If you're on macOS, Linux, or any Unix-like OS, you can set the `bin` folder in the path to directly execute the script.
For example:

```bash
export PATH="$HOME/dotnet-console-apps/bin:$PATH"
```

## License

[MIT](./LICENSE).
