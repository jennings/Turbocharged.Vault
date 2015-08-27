Turbocharged.Vault
==================

A .NET client library for using [Vault](https://vaultproject.io).

Usage
=====

    // Choose an authentication method
    var authentication = new TokenAuthentication(myToken);
    // or: var authentication = new AppIdAuthentication(appId, userId);

    // New up a VaultClient using that authentication
    var client = new VaultClient("https://my.vault.server:8200", authentication);

    // Write a secret to the vault
    var data = new Dictionary<string, object>() { { "password": "sushi" } };
    await client.WriteAsync("secret/foobar", data);

    // Lease a secret
    var lease = await client.LeaseAsync("secret/foobar");
    var password = lease.Data["password"];

    // password == "sushi"


License
=======

MIT license. See `LICENSE.md`.
