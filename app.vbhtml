@ModelType String
@Code
    ViewData("Title") = "VB Razor + Bootstrap Greeting"
End Code

<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <title>@ViewData("Title")</title>
    <!-- Bootstrap CSS -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet">
</head>
<body class="bg-light">

    <div class="container mt-5">
        <div class="row justify-content-center">
            <div class="col-md-6 text-center">
                <h1 class="mb-4">Say Hello</h1>

                @Using Html.BeginForm()
                    <div class="mb-3">
                        <input type="text" name="Name" class="form-control" placeholder="Enter your name" required />
                    </div>
                    <button type="submit" class="btn btn-primary">Greet Me!</button>
                End Using
            </div>
        </div>
    </div>

    @If Not String.IsNullOrEmpty(ViewData("Name")) Then
        <script type="text/javascript">
            alert("Hello! @ViewData("Name")");
        </script>
    End If

</body>
</html>
