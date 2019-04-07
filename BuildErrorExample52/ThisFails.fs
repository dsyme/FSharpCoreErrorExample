namespace BuildErrorExample52

module ThisFails =
    // including the line bellow causes the following error:
    // FS0193	The module/namespace 'Control' from compilation unit 'FSharp.Core' did not contain the val 'ValLinkagePartialKey(OnSuccess)'
    let f = ExampleAsyncLib62.AsyncFunctionsExample.f
