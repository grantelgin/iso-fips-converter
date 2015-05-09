# Simple ISO/FIPS, FIPS/ISO Country Code Conversion Classes #

## Description ##
Static C# classes to convert between <a href='http://en.wikipedia.org/wiki/ISO_3166-1-alpha-2'>ISO 3166-1-alpha-2 country codes</a> and <a href='http://en.wikipedia.org/wiki/List_of_FIPS_country_codes'>FIPS country codes</a> (& vice versa) with an emphasis on speed.

## Usage ##

ISO to FIPS
```
string fipsCode = ISO2ToFIPSConvertor.GetFipsCode(isoCode);
```

FIPS to ISO
```
string isoCode = FIPSToISO2Convertor.GetISO2Code(fipsCode);
```