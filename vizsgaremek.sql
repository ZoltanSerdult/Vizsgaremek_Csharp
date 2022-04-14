-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2022. Már 30. 18:56
-- Kiszolgáló verziója: 10.4.19-MariaDB
-- PHP verzió: 8.0.7

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `vizsgaremek`
--

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `beerkezesek`
--

CREATE TABLE `beerkezesek` (
  `beerk_id` int(11) NOT NULL,
  `beszallito` varchar(50) COLLATE utf8_hungarian_ci NOT NULL,
  `atvetel_datum` datetime NOT NULL,
  `dolgozo_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `beerkezett_termek`
--

CREATE TABLE `beerkezett_termek` (
  `beerk_id` int(11) NOT NULL,
  `termek_id` int(11) NOT NULL,
  `mennyiseg` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `dolgozo`
--

CREATE TABLE `dolgozo` (
  `dolgozo_id` int(11) NOT NULL,
  `felhasznalonev` varchar(50) COLLATE utf8_hungarian_ci NOT NULL,
  `jelszo` varchar(50) COLLATE utf8_hungarian_ci NOT NULL,
  `nev` varchar(50) COLLATE utf8_hungarian_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `dolgozo`
--

INSERT INTO `dolgozo` (`dolgozo_id`, `felhasznalonev`, `jelszo`, `nev`) VALUES
(1, 'Raktaros1', '1234', 'Serdült Zoltán');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `rendeles`
--

CREATE TABLE `rendeles` (
  `rendeles_id` int(11) NOT NULL,
  `vasarlo_id` int(11) NOT NULL,
  `rendeles_datum` datetime NOT NULL,
  `osszeg` int(11) NOT NULL,
  `megjegyzes` text COLLATE utf8_hungarian_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `rendelt_termek`
--

CREATE TABLE `rendelt_termek` (
  `rendeles_id` int(11) NOT NULL,
  `termek_id` int(11) NOT NULL,
  `mennyiseg` int(11) NOT NULL,
  `osszeg` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `termek`
--

CREATE TABLE `termek` (
  `termek_id` int(11) NOT NULL,
  `nev` varchar(50) COLLATE utf8_hungarian_ci NOT NULL,
  `ar` int(11) NOT NULL,
  `keszlet` int(11) NOT NULL,
  `foglalat` varchar(20) COLLATE utf8_hungarian_ci NOT NULL,
  `forma` varchar(20) COLLATE utf8_hungarian_ci NOT NULL,
  `teljesitmeny` int(11) NOT NULL,
  `szinhomerseklet` int(11) NOT NULL,
  `termekkod` varchar(20) COLLATE utf8_hungarian_ci NOT NULL,
  `ean` int(13) NOT NULL,
  `allapot` varchar(20) COLLATE utf8_hungarian_ci NOT NULL,
  `leiras` text COLLATE utf8_hungarian_ci NOT NULL,
  `elerheto` int(1) NOT NULL,
  `akcio` int(1) NOT NULL,
  `marka` varchar(20) COLLATE utf8_hungarian_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- A tábla adatainak kiíratása `termek`
--

INSERT INTO `termek` (`termek_id`, `nev`, `ar`, `keszlet`, `foglalat`, `forma`, `teljesitmeny`, `szinhomerseklet`, `termekkod`, `ean`, `allapot`, `leiras`, `elerheto`, `akcio`, `marka`) VALUES
(2, 'Bright Stick T37 8W E14 3000K', 1090, 0, 'e14', 't37', 8, 3000, 'bse148w3000', 1, 'ép', 'Az Avide LED-fényforrások a hagyományos izzókat helyettesítő magas hatékonyságú LED-ek. Tökéletesek háztartásokban található világítástechnikai megoldások lecserélésére. Többféle formában érhetők el, mint például különböző méretű gömb, mini gömb, stick, gyertya, szpot, reflektív és kapszula. Minden típusú égőnk megtalálható többféle színhőmérsékletben, több különböző foglalattal. Alacsony fogyasztásuknak és hosszú élettartamuknak köszönhetően jelentős megtakarítást eredményeznek. Nem villognak, kímélik a szemet. A ki- és bekapcsolásnak nincs élettartamot rövidítő hatása.\r\n\r\nA LED fényforrások nem egy fémszál felmelegedéséből érik el a fény kibocsátását, hanem elektronok szabadulnak fel, ezáltal minimális a hőveszteségük. LED technológiával a hagyományos izzókhoz képest akár 80%-os energiamegtakarítás is elérhető. A LED fényforrások hőtermelése minimális, ezáltal felhasználható olyan helyeken is, ahol a melegedés veszélyforrás lehet.', 1, 0, ''),
(3, 'Bright Stick T37 8W E14 4000K', 990, 0, 'e14', 't37', 8, 4000, 'bse148w4000', 2, 'épp', 'Az Avide LED-fényforrások a hagyományos izzókat helyettesítő magas hatékonyságú LED-ek. Tökéletesek háztartásokban található világítástechnikai megoldások lecserélésére. Többféle formában érhetők el, mint például különböző méretű gömb, mini gömb, stick, gyertya, szpot, reflektív és kapszula. Minden típusú égőnk megtalálható többféle színhőmérsékletben, több különböző foglalattal. Alacsony fogyasztásuknak és hosszú élettartamuknak köszönhetően jelentős megtakarítást eredményeznek. Nem villognak, kímélik a szemet. A ki- és bekapcsolásnak nincs élettartamot rövidítő hatása.\r\n\r\nA LED fényforrások nem egy fémszál felmelegedéséből érik el a fény kibocsátását, hanem elektronok szabadulnak fel, ezáltal minimális a hőveszteségük. LED technológiával a hagyományos izzókhoz képest akár 80%-os energiamegtakarítás is elérhető. A LED fényforrások hőtermelése minimális, ezáltal felhasználható olyan helyeken is, ahol a melegedés veszélyforrás lehet.', 1, 0, ''),
(4, 'Candle C35 4W E14 4000K', 990, 0, 'e14', 'c35', 4, 4000, 'ce144w4000', 3, 'épp', 'Az Avide LED-fényforrások a hagyományos izzókat helyettesítő magas hatékonyságú LED-ek. Tökéletesek háztartásokban található világítástechnikai megoldások lecserélésére. Többféle formában érhetők el, mint például különböző méretű gömb, mini gömb, stick, gyertya, szpot, reflektív és kapszula. Minden típusú égőnk megtalálható többféle színhőmérsékletben, több különböző foglalattal. Alacsony fogyasztásuknak és hosszú élettartamuknak köszönhetően jelentős megtakarítást eredményeznek. Nem villognak, kímélik a szemet. A ki- és bekapcsolásnak nincs élettartamot rövidítő hatása.\r\n\r\nA LED fényforrások nem egy fémszál felmelegedéséből érik el a fény kibocsátását, hanem elektronok szabadulnak fel, ezáltal minimális a hőveszteségük. LED technológiával a hagyományos izzókhoz képest akár 80%-os energiamegtakarítás is elérhető. A LED fényforrások hőtermelése minimális, ezáltal felhasználható olyan helyeken is, ahol a melegedés veszélyforrás lehet.', 1, 0, ''),
(5, 'Candle C35 4W E14 3000K', 990, 0, 'e14', 'c35', 4, 3000, 'ce144w3000', 4, 'épp', 'Az Avide LED-fényforrások a hagyományos izzókat helyettesítő magas hatékonyságú LED-ek. Tökéletesek háztartásokban található világítástechnikai megoldások lecserélésére. Többféle formában érhetők el, mint például különböző méretű gömb, mini gömb, stick, gyertya, szpot, reflektív és kapszula. Minden típusú égőnk megtalálható többféle színhőmérsékletben, több különböző foglalattal. Alacsony fogyasztásuknak és hosszú élettartamuknak köszönhetően jelentős megtakarítást eredményeznek. Nem villognak, kímélik a szemet. A ki- és bekapcsolásnak nincs élettartamot rövidítő hatása.\r\n\r\nA LED fényforrások nem egy fémszál felmelegedéséből érik el a fény kibocsátását, hanem elektronok szabadulnak fel, ezáltal minimális a hőveszteségük. LED technológiával a hagyományos izzókhoz képest akár 80%-os energiamegtakarítás is elérhető. A LED fényforrások hőtermelése minimális, ezáltal felhasználható olyan helyeken is, ahol a melegedés veszélyforrás lehet.', 1, 0, ''),
(6, 'Globe A60 8W E27 4000K', 890, 0, 'e27', 'a60', 8, 4000, 'ge278w4000', 5, 'épp', 'Az Avide LED-fényforrások a hagyományos izzókat helyettesítő magas hatékonyságú LED-ek. Tökéletesek háztartásokban található világítástechnikai megoldások lecserélésére. Többféle formában érhetők el, mint például különböző méretű gömb, mini gömb, stick, gyertya, szpot, reflektív és kapszula. Minden típusú égőnk megtalálható többféle színhőmérsékletben, több különböző foglalattal. Alacsony fogyasztásuknak és hosszú élettartamuknak köszönhetően jelentős megtakarítást eredményeznek. Nem villognak, kímélik a szemet. A ki- és bekapcsolásnak nincs élettartamot rövidítő hatása.\r\n\r\nA LED fényforrások nem egy fémszál felmelegedéséből érik el a fény kibocsátását, hanem elektronok szabadulnak fel, ezáltal minimális a hőveszteségük. LED technológiával a hagyományos izzókhoz képest akár 80%-os energiamegtakarítás is elérhető. A LED fényforrások hőtermelése minimális, ezáltal felhasználható olyan helyeken is, ahol a melegedés veszélyforrás lehet.', 1, 0, ''),
(7, 'fénycsö', 1000, 20, 'Gömb', 'Ovális', 120, 12, 'DEB214', 434312321, 'Épp', 'Lurem ipsum', 1, 20, 'Lux'),
(8, '30 cm-es T5 LED fénycső armatúrával', 2500, 2, 'T5', '', 123, 2500, 'DEB001', 658697, 'Épp', 'Cseréld le áramzabáló világításodat erre a praktikus, energiatakarékos fénycsőre! A 30 cm-es armatúra bárhova felszerelhető, így akár a mosogatót vagy a fürdőszobai tükröt is tökéletesen megvilágíthatod. Az armatúrán találsz egy kapcsolót, a mellékelt villásdugó pedig még egyszerűbbé teszi beüzemelését. A T5-ös fénycső 4W fogyasztás mellett kb. 40W-os fényerőt biztosít.', 2, 5, 'Outor'),
(9, 'Minuszos', 2000, -5, 'Nincs', 'Formás', 100, 100, 'DEB001-23', 223423, '2', 'nincs', 0, 20, 'Valami');

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `vasarlo`
--

CREATE TABLE `vasarlo` (
  `vasarlo_id` int(11) NOT NULL,
  `vnev` varchar(20) COLLATE utf8_hungarian_ci NOT NULL,
  `knev` varchar(20) COLLATE utf8_hungarian_ci NOT NULL,
  `email` varchar(30) COLLATE utf8_hungarian_ci NOT NULL,
  `phone` varchar(20) COLLATE utf8_hungarian_ci NOT NULL,
  `elfogadva` datetime NOT NULL,
  `jelszo` varchar(30) COLLATE utf8_hungarian_ci NOT NULL,
  `irszam` varchar(20) COLLATE utf8_hungarian_ci NOT NULL,
  `varos` varchar(50) COLLATE utf8_hungarian_ci NOT NULL,
  `utca` varchar(50) COLLATE utf8_hungarian_ci NOT NULL,
  `hazszam` varchar(20) COLLATE utf8_hungarian_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `beerkezesek`
--
ALTER TABLE `beerkezesek`
  ADD PRIMARY KEY (`beerk_id`),
  ADD KEY `dolgozo` (`dolgozo_id`);

--
-- A tábla indexei `beerkezett_termek`
--
ALTER TABLE `beerkezett_termek`
  ADD KEY `beerkezes` (`beerk_id`),
  ADD KEY `termek` (`termek_id`);

--
-- A tábla indexei `dolgozo`
--
ALTER TABLE `dolgozo`
  ADD PRIMARY KEY (`dolgozo_id`);

--
-- A tábla indexei `rendeles`
--
ALTER TABLE `rendeles`
  ADD PRIMARY KEY (`rendeles_id`),
  ADD KEY `vasarloo` (`vasarlo_id`);

--
-- A tábla indexei `rendelt_termek`
--
ALTER TABLE `rendelt_termek`
  ADD KEY `rendeles` (`rendeles_id`),
  ADD KEY `termekk` (`termek_id`);

--
-- A tábla indexei `termek`
--
ALTER TABLE `termek`
  ADD PRIMARY KEY (`termek_id`);

--
-- A tábla indexei `vasarlo`
--
ALTER TABLE `vasarlo`
  ADD PRIMARY KEY (`vasarlo_id`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `beerkezesek`
--
ALTER TABLE `beerkezesek`
  MODIFY `beerk_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT a táblához `dolgozo`
--
ALTER TABLE `dolgozo`
  MODIFY `dolgozo_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT a táblához `rendeles`
--
ALTER TABLE `rendeles`
  MODIFY `rendeles_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT a táblához `termek`
--
ALTER TABLE `termek`
  MODIFY `termek_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT a táblához `vasarlo`
--
ALTER TABLE `vasarlo`
  MODIFY `vasarlo_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- Megkötések a kiírt táblákhoz
--

--
-- Megkötések a táblához `beerkezesek`
--
ALTER TABLE `beerkezesek`
  ADD CONSTRAINT `dolgozo` FOREIGN KEY (`dolgozo_id`) REFERENCES `dolgozo` (`dolgozo_id`);

--
-- Megkötések a táblához `beerkezett_termek`
--
ALTER TABLE `beerkezett_termek`
  ADD CONSTRAINT `beerkezes` FOREIGN KEY (`beerk_id`) REFERENCES `beerkezesek` (`beerk_id`),
  ADD CONSTRAINT `termek` FOREIGN KEY (`termek_id`) REFERENCES `termek` (`termek_id`);

--
-- Megkötések a táblához `rendeles`
--
ALTER TABLE `rendeles`
  ADD CONSTRAINT `vasarlo` FOREIGN KEY (`vasarlo_id`) REFERENCES `vasarlo` (`vasarlo_id`);

--
-- Megkötések a táblához `rendelt_termek`
--
ALTER TABLE `rendelt_termek`
  ADD CONSTRAINT `rendeles` FOREIGN KEY (`rendeles_id`) REFERENCES `rendeles` (`rendeles_id`),
  ADD CONSTRAINT `termekk` FOREIGN KEY (`termek_id`) REFERENCES `termek` (`termek_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
