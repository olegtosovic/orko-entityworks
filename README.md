<!-- PROJECT SHIELDS -->
[![GitHub contr](https://img.shields.io/github/contributors/olegtosovic/orko-entityworks?style=for-the-badge)](https://github.com/olegtosovic/orko-entityworks/contributors)
[![GitHub forks](https://img.shields.io/github/forks/olegtosovic/orko-entityworks?style=for-the-badge)](https://github.com/olegtosovic/orko-entityworks/network)
[![GitHub issues](https://img.shields.io/github/issues/olegtosovic/orko-entityworks?style=for-the-badge)](https://github.com/olegtosovic/orko-entityworks/issues)
[![GitHub stars](https://img.shields.io/github/stars/olegtosovic/orko-entityworks?style=for-the-badge)](https://github.com/olegtosovic/orko-entityworks/stargazers)
[![GitHub license](https://img.shields.io/github/license/olegtosovic/orko-entityworks?style=for-the-badge)](https://github.com/olegtosovic/orko-entityworks/blob/master/LICENSE.md)

<!-- PROJECT TITLE AND BASIC DESCRIPTION -->
# EntityWorks .NET

EntityWorks is a simple active record object-database mapper for .NET 5 currently supporting only Microsoft SQL Server. It provides Query class for building complex SQL queries that provide data mapping to table entities or custom objects models in almost native assignment speed. Being highly optimized it uses CLR generic type static caching reflection which enables minimalistic DTO-like generated entities with addition of async CRUD methods.

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
/// Get single entity given query.
/// </summary>
public static async Task<PrometnaKartica> TryDohvatiPrometnuKarticuZaTerminAsync(
    string jezik,
    int brod,
    string vrstaUsluge,
    string vrstaIzleta,
    DateTime datumVrijemeOd, 
    DateTime datumVrijemeDo)
{
    // Create new query.
    var upit = new Query();

    // Select Protokol table.
    upit.Select("ProtokolProtokol");
    upit.Select("ProtokolGodina");
    upit.Select("ProtokolBroj");
    upit.Select("ProtokolStatus");
    upit.Select("ProtokolDatumDokumenta");

    // Select PrometnaKartica table.
    upit.Select("PrometnaKarticaProtokolID");
    upit.Select("PrometnaKarticaBrod");
    upit.Select("PrometnaKarticaVrstaUsluge");
    upit.Select("PrometnaKarticaVrstaIzleta");;

    // Select name fields from language tables.
    upit.Select("VrstaUslugeNaziv");
    upit.Select("VrstaIzletaNaziv");
    upit.Select("TipRezervacijeNaziv");
    upit.Select("TerminNaziv");

    // From.
    upit.From("Watersports.PrometnaKartica");

    // Inner join.
    upit.Join("Base.Protokol", "PrometnaKarticaProtokolID", "ProtokolID");

    // Left join.
    upit.JoinLeft("Watersports.Termin_jezik AS terminJezik",
        new QueryCondition("terminJezik.TerminID", QueryOp.Equal, "PrometnaKarticaTerminID"),
        new QueryCondition("terminJezik.TerminJezik", QueryOp.Equal, Query.Quote(jezik)));

    // Left join.
    upit.JoinLeft("Watersports.Brod_jezik AS brodJezik",
        new QueryCondition("brodJezik.BrodBrod", QueryOp.Equal, "PrometnaKarticaBrod"),
        new QueryCondition("brodJezik.BrodJezik", QueryOp.Equal, Query.Quote(jezik)));

    // Left join.
    upit.JoinLeft("Watersports.VrstaUsluge_jezik AS vrstaUslugeJezik",
        new QueryCondition("vrstaUslugeJezik.VrstaUslugeVrstaUsluge", QueryOp.Equal, "PrometnaKarticaVrstaUsluge"),
        new QueryCondition("vrstaUslugeJezik.VrstaUslugeJezik", QueryOp.Equal, Query.Quote(jezik)));

    // Filter conditions.
    upit.Where("PrometnaKarticaBrod", QueryOp.Equal, Query.Quote(brod));
    upit.Where("PrometnaKarticaVrstaUsluge", QueryOp.Equal, Query.Quote(vrstaUsluge));
    if (vrstaIzleta != null)
            upit.Where("PrometnaKarticaVrstaIzleta", QueryOp.Equal, Query.Quote(vrstaIzleta));
    else upit.Where("PrometnaKarticaVrstaIzleta", QueryOp.Equal, Query.Quote("NEMA"));
    upit.Where("PrometnaKarticaDatumVrijemeOd", QueryOp.Equal, Query.Quote(datumVrijemeOd));
    upit.Where("PrometnaKarticaDatumVrijemeDo", QueryOp.Equal, Query.Quote(datumVrijemeDo));

    // Get entity collection async.
    var prometnaKartica = (await upit
        .GetEntityCollectionAsync<PrometnaKartica>())
        .FirstOrDefault();

    // Return entity.
    return prometnaKartica;
}
```
Please don't mind the Croatian language of variable names, because this sample is taken from existing project that is written as it is.

### Sample CRUD operations

```cs

```

### Entity & Model Mapping

```cs

```

### Generating Entity classes

```cs

```

## Explanations

In following text, some of the main general concepts, usages and classes are explained.

### EntityWorksContext

### ConnectionContext

### QueryContext

### EntityContext

### ObjectContext

### Ambient pattern

### Configuration

### Authentication ambient query context switching

### Entity & Model metadata caching

<!-- ROADMAP -->
## Roadmap

List of some features that will be implemented down the road:

1. Futher extensions of Query class so that it provides more complete sql query writing.
2. EntityWorks providers for other common database engines. (MySql, Oracle, etc.)
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
