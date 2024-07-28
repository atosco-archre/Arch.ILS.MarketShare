
using Arch.ILS.Common;

ConnectionProtection connectionProtection =
    new ConnectionProtection(@"C:\Users\atosco\source\repos\Arch.MarketShare\Arch.MarketShare.Console\App.config.config");
//if (!connectionProtection.IsProtected())
//    connectionProtection.EncryptFile();
RevoConnectionStrings connectionSettings = new RevoConnectionStrings(connectionProtection,false);