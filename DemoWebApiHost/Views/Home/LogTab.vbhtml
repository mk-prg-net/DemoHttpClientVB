@ModelType DemoWebApiHost.Telegram()

<table class="table table-striped">
    <tr>
        <th>Zeit</th>
        <th>ID</th>
        <th>Msg</th>
    </tr>
    @For Each tel In Model

        @<tr>
            <td>@tel.Posted.ToLongTimeString()</td>
            <td>@tel.ID.ToString()</td>
            <td>@tel.Msg</td>
        </tr>
    Next
</table>