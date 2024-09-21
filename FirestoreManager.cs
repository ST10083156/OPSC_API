using Google.Cloud.Firestore;

namespace OPSC_API
{
    public static class FirestoreManager
    {
        static string fireConfig = @"{
  ""type"": ""service_account"",
  ""project_id"": ""opsc-quizcore"",
  ""private_key_id"": ""66e06dfc74bc03e9443ef5d4ad3454da80fc843f"",
  ""private_key"": ""-----BEGIN PRIVATE KEY-----\nMIIEvgIBADANBgkqhkiG9w0BAQEFAASCBKgwggSkAgEAAoIBAQDQq8ZKpHKAas8I\nJT72HCeEW6EXXjQKrJTnLP/A3JaCc6HZxhGlP5s1p/OgPDiNQyuoZ9MEkX80ZMrl\nKeH8E/ldAeVaFWE04ZAjbqF91hcXtvHKq7mZ+aE279BXNgbmxnG6uk8jt/hWcM2m\nR8e73zuCCrH1WA//CGvHg9Tfhollexwv4iwI1vazl2rqTE/13VAegf88gbu5GAz/\n1BAOaoh3iI5UG1l+EazjdcnLW8jNByl4e5708vGWRRHpe1L+F7hv0VO8wXR/2REp\nILeEPfz5AyOJ/x95N3vc7/Bwfe9N66NLBIrw/mcBGyIJNyy3/ONAFpm18LOyTtvU\n8dEofwt9AgMBAAECggEAG+F/rpR3WhIrVF7JoU+UthoaFYm4MV7qzFKWX3n5wDdb\n/kF5NRehENO+eP/i3HkHmco5hyg7k1AOTf1BHRG8JUGuF9G4ebzTqfBLsokK79e5\nSceVFm4krLbxIt3soSQNqRHgphicHUyYJan8lW0XweHU8j+Qb5Z79B34sN8Ed6Lz\n5rHwjPhX/jEX5iFmKiPMKTAC0ZFSOvEWovcxIpy+mG4Dv411eWzPMbvmLsw+di4n\n1vNfyjuj/SCPIR7NDNz8HMJ8SBGXogrOxwubpPMBnv/aSvwOXnKLDGwCW7nvzM0x\n4pfemCcgg4Tm7w2QLg9UobjHFhlCn6kd6cWm681x7wKBgQD59lS8KsWJTzxUS4yV\nVrZdr04CG3IV6ZbL4H4WGVVKY7+yyJYtrKrfonzl5zJErjZoAqiLc2Jok7hWqXVn\nG83L9tfgw9W5469HlFEhGmRP5LTCV7kAW1DkqCqObGwDKL/uVceaZkR1Umry+vz4\nami2whYKlrbubxCsCodp3Q15owKBgQDVth1bFW2uR2zCLoFj8772YbD4VQ1fjNa8\nicW9kAyCd+1ljIIWBr94JfD8BPOr5brX2fqUsb8hRlwieaIxxDRZQ9nM8Vo/YPaW\nO8rYitaLvHRZEt1nj+RpqIqnw8XOp4CdnqKhKsTqx06RbyDV9OwMxS2whu2e0gWO\nNbFwn0P4XwKBgQCcGxQGQ+wD+eEif+A3b+UKky3zsPJJ7w0HHJeB86ZJhAw3eoAX\n3EsGyXKZHg9Nx0MhJ+/cz125E/A+5yv0DfAznmBp9cPniONxn5YfR104bAvbh295\nYo4dj0ysj9fRDUT4csfqjE3au3MhdlBAUCw/XuznBgMO23wdBaJWIgCFYwKBgQCY\n81XfMl7lNEkqUI5aMsChJRm7IWQI1ot5NEFJgibx2VMWMpGHohy2qLDoLcMXa7tl\ncKRedzgLYIfgRJ1IcNvmZyEiBDpK0eKpcvGiOPuD1sSOW2oKDHm1BOL3Xq3bURZD\nuJ08K5fzT+FzRM2DU179ZMFmbary1+0R8muj5tiGkQKBgFf28I4ZgCFZSSffysMc\ngosSg2czdgfY9Gf5s6Cchnbdio2mOFwj+Ohje+5pdR1Rqn7I0XB1WIEEl+IWsWh3\nTSv7H51nT63PZ1JLUud/z4Tfl3sDeq7sigd7SVw4eCOHsLQ7C7BJLFYPSKO0RV/F\nJT3Zu742PBEY0AA/wKlgYt7/\n-----END PRIVATE KEY-----\n"",
  ""client_email"": ""firebase-adminsdk-x9j87@opsc-quizcore.iam.gserviceaccount.com"",
  ""client_id"": ""105896563649833274892"",
  ""auth_uri"": ""https://accounts.google.com/o/oauth2/auth"",
  ""token_uri"": ""https://oauth2.googleapis.com/token"",
  ""auth_provider_x509_cert_url"": ""https://www.googleapis.com/oauth2/v1/certs"",
  ""client_x509_cert_url"": ""https://www.googleapis.com/robot/v1/metadata/x509/firebase-adminsdk-x9j87%40opsc-quizcore.iam.gserviceaccount.com"",
  ""universe_domain"": ""googleapis.com""
    }";

        static string filePath = "";

        public static FirestoreDb? db;

        public static void SetEnvironmentVariable()
        {
            filePath = Path.Combine(Path.GetTempPath(), Path.GetFileNameWithoutExtension(Path.GetRandomFileName())) + ".json";
            File.WriteAllText(filePath, fireConfig);
            File.SetAttributes(filePath, FileAttributes.Hidden);
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", filePath);
            db = FirestoreDb.Create("opsc-quizcore");
            File.Delete(filePath);
        }
    }
}
