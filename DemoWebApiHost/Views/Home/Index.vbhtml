@ModelType DemoWebApiHost.Telegram()
<div class="jumbotron">
    <h1>ASP.NET</h1>
    <p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS, and JavaScript.</p>
    <p><a href="http://asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>
</div>
<div class="row">


    <button id="btnJsTestPost" class="btn btn-primary">WebApi mit JQuery aus Browser aufrufen</button>

    <h3>Log Tabelle der WebApi Aufrufe</h3>
    <p>
        Hier werden die einzelnen Aufrufe von WebApi- Actions protokolliert. Das Protokoll befindet sich im Anwendungszustand 
        der Webanwendung (Application). Es wird mittels JavaScript/Ajax periodisch aktualisiert
    </p>
    <div id="LogTab">

    </div>
    
</div>

<div Class="row">
    <div Class="col-md-4">
        <h2> Getting started</h2>
        <p>
            ASP.NET Web API Is a framework that makes it easy To build HTTP services that reach
            a broad range Of clients, including browsers And mobile devices. ASP.NET Web API
            Is an ideal platform for building RESTful applications on the .NET Framework.
        </p>
        <p> <a Class="btn btn-default" href="http://go.microsoft.com/fwlink/?LinkId=301870">Learn more &raquo;</a></p>
    </div>
    <div Class="col-md-4">
        <h2> Get more libraries</h2>
        <p> NuGet Is a free Visual Studio extension that makes it easy To add, remove, And update libraries And tools In Visual Studio projects.</p>
        <p> <a Class="btn btn-default" href="http://go.microsoft.com/fwlink/?LinkId=301871">Learn more &raquo;</a></p>
    </div>
    <div Class="col-md-4">
        <h2> Web Hosting</h2>
        <p> You can easily find a web hosting company that offers the right mix Of features And price For your applications.</p>
        <p> <a Class="btn btn-default" href="http://go.microsoft.com/fwlink/?LinkId=301872">Learn more &raquo;</a></p>
    </div>
</div>


@Section scripts
    <script src="~/Scripts/Home/Index/DocumentReady.js"></script>
End Section


