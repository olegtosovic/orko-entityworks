
<!-- PROJECT TITLE AND BASIC DESCRIPTION -->
# EntityWorks .NET

EntityWorks is a simple active record object-database mapper for .NET 5 currently supporting only Microsoft SQL Server. It provides Query class for building complex SQL queries that provide data mapping to table entities or custom objects models in almost native assignment speed. Being highly optimized it uses CLR generic type static caching reflection which enables minimalistic DTO-like generated entities with addition of async CRUD methods. It is connection oriented which means no DbContext but rather QueryContext that operates as ambient context.

<!-- ABOUT THE PROJECT -->
## About The Project

<!-- INSTALATION -->
## Installation

EntityWorks is available on NuGet. Install appropriate packages depending on your runtime environment.

### Asp Net Core

```sh
dotnet add package Orko.EntityWorks.AspNetCore
dotnet add package Orko.EntityWorks.Generator.AspNetCore
```
  
### Desktop apps

```sh
dotnet add package Orko.EntityWorks
dotnet add package Orko.EntityWorks.Generator
```
  
<!-- USAGE -->
## Usage

The following code demonstrates basic usage of EntityWorks .NET. 

### Sample querying.

```cs
/// <summary>
/// Dohvaća prometnu karticu za ključ usluge.
/// </summary>
public static async Task<PrometnaKartica> TryDohvatiPrometnuKarticuZaTerminAsync(
    string jezik,
    int brod,
    string vrstaUsluge,
    string vrstaIzleta,
    DateTime datumVrijemeOd, 
    DateTime datumVrijemeDo)
{
    // Upit.
    var upit = new Query();

    // Select protokol.
    upit.Select("ProtokolProtokol");
    upit.Select("ProtokolGodina");
    upit.Select("ProtokolBroj");
    upit.Select("ProtokolStatus");
    upit.Select("ProtokolDatumDokumenta");

    // Select prometna kartica.
    upit.Select("PrometnaKarticaProtokolID");
    upit.Select("PrometnaKarticaBrod");
    upit.Select("PrometnaKarticaVrstaUsluge");
    upit.Select("PrometnaKarticaVrstaIzleta");
    upit.Select("PrometnaKarticaTipRezervacije");
    upit.Select("PrometnaKarticaTerminID");
    upit.Select("PrometnaKarticaDatumUsluge");
    upit.Select("PrometnaKarticaDatumVrijemeOd");
    upit.Select("PrometnaKarticaDatumVrijemeDo");
    upit.Select("PrometnaKarticaVrijemeOd");
    upit.Select("PrometnaKarticaVrijemeDo");
    upit.Select("PrometnaKarticaTrajanjeIdealno");
    upit.Select("PrometnaKarticaTrajanjeStvarno");
    upit.Select("PrometnaKarticaPovratakProcjena");
    upit.Select("PrometnaKarticaPovratakStvarno");
    upit.Select("PrometnaKarticaBrojOsobaStvarno");
    upit.Select("PrometnaKarticaBrojOsobaKalkulativno");
    upit.Select("PrometnaKarticaBrojOsobaPreostaloStvarno");
    upit.Select("PrometnaKarticaBrojOsobaPreostaloKalkulativno");
    upit.Select("PrometnaKarticaBrojOdraslih");
    upit.Select("PrometnaKarticaBrojDjece");
    upit.Select("PrometnaKarticaSkiperUkljucen");
    upit.Select("PrometnaKarticaCijenaUslugeCjenik");
    upit.Select("PrometnaKarticaCijenaUslugePopustPostotak");
    upit.Select("PrometnaKarticaCijenaUslugePopustIznos");
    upit.Select("PrometnaKarticaCijenaUslugeKonacno");
    upit.Select("PrometnaKarticaCijenaUslugeNaplaceno");

    // Select nazivi.
    upit.Select("VrstaUslugeNaziv");
    upit.Select("VrstaIzletaNaziv");
    upit.Select("TipRezervacijeNaziv");
    upit.Select("TerminNaziv");

    // From.
    upit.From("Watersports.PrometnaKartica");

    // Join protokol.
    upit.Join("Base.Protokol", "PrometnaKarticaProtokolID", "ProtokolID");

    // Join termin jezik.
    upit.JoinLeft("Watersports.Termin_jezik AS terminJezik",
        new QueryCondition("terminJezik.TerminID", QueryOp.Equal, "PrometnaKarticaTerminID"),
        new QueryCondition("terminJezik.TerminJezik", QueryOp.Equal, Query.Quote(jezik)));

    // Join brod jezik.
    upit.JoinLeft("Watersports.Brod_jezik AS brodJezik",
        new QueryCondition("brodJezik.BrodBrod", QueryOp.Equal, "PrometnaKarticaBrod"),
        new QueryCondition("brodJezik.BrodJezik", QueryOp.Equal, Query.Quote(jezik)));

    // Join vrsta usluge jezik.
    upit.JoinLeft("Watersports.VrstaUsluge_jezik AS vrstaUslugeJezik",
        new QueryCondition("vrstaUslugeJezik.VrstaUslugeVrstaUsluge", QueryOp.Equal, "PrometnaKarticaVrstaUsluge"),
        new QueryCondition("vrstaUslugeJezik.VrstaUslugeJezik", QueryOp.Equal, Query.Quote(jezik)));

    // Join vrsta izleta jezik.
    upit.JoinLeft("Watersports.VrstaIzleta_jezik AS vrstaIzletaJezik",
        new QueryCondition("vrstaIzletaJezik.VrstaIzletaVrstaIzleta", QueryOp.Equal, "PrometnaKarticaVrstaIzleta"),
        new QueryCondition("vrstaIzletaJezik.VrstaIzletaJezik", QueryOp.Equal, Query.Quote(jezik)));

    // Join tip rezervacije jezik.
    upit.JoinLeft("Watersports.TipRezervacije_jezik AS tipRezervacijeJezik",
        new QueryCondition("tipRezervacijeJezik.TipRezervacijeTipRezervacije", QueryOp.Equal, "PrometnaKarticaTipRezervacije"),
        new QueryCondition("tipRezervacijeJezik.TipRezervacijeJezik", QueryOp.Equal, Query.Quote(jezik)));

    // Uvjeti za ključ usluge.
    upit.Where("PrometnaKarticaBrod", QueryOp.Equal, Query.Quote(brod));
    upit.Where("PrometnaKarticaVrstaUsluge", QueryOp.Equal, Query.Quote(vrstaUsluge));
    if (vrstaIzleta != null)
            upit.Where("PrometnaKarticaVrstaIzleta", QueryOp.Equal, Query.Quote(vrstaIzleta));
    else upit.Where("PrometnaKarticaVrstaIzleta", QueryOp.Equal, Query.Quote("NEMA"));
    upit.Where("PrometnaKarticaDatumVrijemeOd", QueryOp.Equal, Query.Quote(datumVrijemeOd));
    upit.Where("PrometnaKarticaDatumVrijemeDo", QueryOp.Equal, Query.Quote(datumVrijemeDo));

    // Dohvati prometnu karticu.
    var prometnaKartica = (await upit
        .GetEntityCollectionAsync<PrometnaKartica>())
        .FirstOrDefault();

    // Vrati prometnu karticu.
    return prometnaKartica;
}
```
Please don't mind the Croatian language of variable names, because this sample is taken from existing project that is written as it is.


<!-- ROADMAP -->
## Roadmap

List of some features that will be implemented down the road:

1. Futher extensions of Query class so that it provides more complete sql query writing.
2. Providers for other common database engines. (MySql, Oracle, etc.)
3. Implementation and support for database view (both entityworks runtime and generator).
4. Implementation and support for database stored procedures (both entityworks runtime and generator).

See the [open issues](https://github.com/olegtosovic/orko-entityworks/issues) for a list of proposed features (and known issues).

<!-- CONTRIBUTING -->
## Contributing

Contributions are what make the open source community such an amazing place to be learn, inspire, and create. Any contributions you make are **greatly appreciated**.

1. Contact me about new feature or report an issue.
2. Fork the Project.
3. Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
4. Commit your Changes (`git commit -m 'Add some AmazingFeature'`)
5. Push to the Branch (`git push origin feature/AmazingFeature`)
6. Open a Pull Request

<!-- LICENSE -->
## License

Distributed under the APACHE 2.0 License. See `LICENSE` for more information.

<!-- CONTACT -->
## Contact

Oleg Tošović - oleg.tosovic@gmail.com

Orko I.T. - https://www.orkoit.hr/en

Project Link: [https://github.com/olegtosovic/orko-entityworks.git](https://github.com/olegtosovic/orko-entityworks.git)


