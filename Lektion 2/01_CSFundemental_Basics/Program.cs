#region Comment

/* */

///test

Console.WriteLine("Beesg!");
Console.ReadKey();

#endregion

#region Data Types

/*
 
    Frontend (ASP .NET) - Backend (ASP .NET) - DATABASE (MSQL)
    Frontend (React JS) - Backend API (API) - DATABASE (MSQL)

    JS (Javascript)            C# (C-Sharp)                      SQL (meh?)
   ----------------------------------------------------------------
   (Number types)
    Number                sbyte, byte, ushort,              bit, tinyint, smallint, int, bigint,
                          in, uint, long, ulong,            decimal, float, real, smallmoney, money
                          int16, int32, int64               Numeric
    (
    String                Char, String                      char, varchar, nchar, nvarchar, text
    

    Boolean               bool                              bit

    C# Integrals
    TYPE            BIT         RANGE (START/END)   8, 16 ,32, 64, 128,256, 512,1024, 2048, 4096, 8192, 16384, 32768, 65536
    ------------------------------------------------------------------------------------------------------------
    sbyte           8           -128        127
    *byte           8           0           255
    short           16          -32768      32767
    ushort          16          0           65535    
    *int            32          -2147483648 2147483648
    uint            32          0           4292967295  
    *long           64          too many    too many
    ulong           64          too many    too many
    
    int16           16          samma som short
    int32           16          samma som int
    int64           16          samma som long

// * = viktig att kunna
// använder mindre bitars språk för att minska utrymme och öka effektiviteten
   
    C# Floating points
    TYPE            BYTES           DECIMAL RANGE           SUFFIX          USED FOR
    -------------------------------------------------------------------------------------------------------
    float           4           6-9 digits              f eller F           lämplig fö Machine learning
    double          8           15-16 digits            d eller D           lämplig för att Optimering av prestanda/Lagring
    decimal         16          28-29 digits            m eller M           lämplig för finansiella tal, som pengar



    C# Strings
    TYPE            BIT         SCHEME                        CHAR RANGE
    ----------------------------------------------------------------------------------------------------------
    char            16          ASCII/UTF-8 (unicode)           ASCII(X+0000 -> X+FFFF) UFT8 (U+0000 -> U+FFFF)
    string          64          ASCII/UTF-8 (unicode)           MAX 2GB (~1 000 000 000 tecken)

    ASCII = Engelska tangentbordet
    UTF-8 = Svenskt tangentbord (dvs specialtecken, åäö)


    Om vi ska skriva en text så använder vi citat tecken
    Vi gör det för att det kan innehålla mer information.

    char text = 'Y'; För en karaktär

    String test = "jag är \"inte\" bäst i världen"; för en hel text, kan innehålla mer infor

    \" \" = talar om att den ska läsa nästa textsvängen som helt vanlig text
    @" " = Läser hela texten som vanlig text
    $" " = Läser som placeholders
    \n = radbrytning
    \t = text

    C# Boolean
    TYPE            BIT         VALUES
    --------------------------------------------------------------------------------------
    bool            0/1        false/true

    
    C# Guid ( Global Unique Identifier)
    VAIABLE       BYTES             COMMAND             RESULT
    -----------------------------------------------------------------------------------------------
    Guid id;       16             Guid.NewGuid();        Unikt ID



 */

float sumFloat = 0.1f + 0.1f + 0.1F;
double sumDouble = 0.1d + 0.1d + 0.1d;
decimal sumDecimal = 0.1m + 0.1m + 0.1m;

Console.WriteLine("Float: " + sumFloat);
Console.WriteLine("Double: " + sumDouble);
Console.WriteLine("Decimal: " + sumDecimal);

string firstName = "Morten";
string lastName = "Folkeson";
int age = 23;

string text = "Hej jag heter Morten Folkesson och jag är 23 år";
string placeholder = $"Jag heter {firstName} {lastName} och jag är {age} år";

int tal1 = 1;
int tal2 = 2; 
int sum = tal1 + tal2;








Console.ReadKey();
#endregion


#region VARIABLES

/*
 
    VARIABEL   
    SPRÅK       MODELL          EXEMPEL         BESKRIVNING
    -------------------------------------------------------------------------------------------------
    C#          Pascal          FirstName       Stor bokstav på varje ord
    JS          camelCase       firstName       Första ordet börjar på liten bokstav, andra stor
    Java        camelCase       firstName       Första ordet börjar på liten bokstav, andra stor    
    C/C++       camelCase       firstName       Första ordet börjar på liten bokstav, andra stor
    Python      snake_case      first_name      Varje ord seperaeras med "_"
 

    Design Pattern
    -------------------------------------------------------------------------------------
    Field         firstName                     inuti en klass
    Property      FirstName                     inuti en klass med Getters Setters
    parameter     firstName                     input till en metod
    Variable      firstName, FirstName          inuti en metod


    Deklarera variabler
    ------------------------------------------------------------------------------------------------------
    string firstName            Deklarera med en Fast datatyp
    var firstName = "Morten";   Deklarera med en icke Fast datatyp, den Blir den datatypen som sätts
 
 
    Konvertera datatyper
    ------------------------------------------------------------------------------------
    byte.parse()        omvandlar det som står till en byte
    int.parse()         omvandlar det som står till ett heltal
    bool.parse()        omvandlar det som står till en true/false värde
    long.parse()        omvandlar det som står till ett int64 värde
    decimal.parse()     omvandlar det som står till en


 */

int.Parse(placeholder);

#endregion