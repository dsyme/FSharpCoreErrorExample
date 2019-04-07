namespace ExampleAsyncLib52

module AsyncFunctionsExample =
    let inline f x = async.Return x // has to be inline for the error to occur
