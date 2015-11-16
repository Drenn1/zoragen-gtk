# Oracle of Secrets Password Generator [![Travis CI Build Status](https://travis-ci.org/kabili207/oracle-of-secrets-gtk.svg?branch=master)](https://travis-ci.org/kabili207/oracle-of-secrets-gtk) [![AppVeyor Build status](https://ci.appveyor.com/api/projects/status/p6hcxt2xfal44mmo/branch/master?svg=true)](https://ci.appveyor.com/project/kabili207/oracle-of-secrets-gtk/branch/master)

A generator and decoder for the password system used in the Legend of Zelda Oracle of Ages and Oracle of Seasons games.
Built using the [OracleHack](https://github.com/kabili207/oracle-hack) library.

### Features
 * Decodes game and ring secrets
 * Generates game, ring, and memory secrets
 * Allows the user to save the game information for later use

### TODO
 * Include a debugging screen to get raw information about secrets

### Special Thanks
 * Paulygon - Created the [original secret generator](http://home.earthlink.net/~paul3/zeldagbc.html) way back in 2001
 * 39ster - Rediscovered [how to decode game secrets](http://www.gamefaqs.com/boards/472313-the-legend-of-zelda-oracle-of-ages/66934363) using paulygon's program
 * [LunarCookies](https://github.com/LunarCookies) - Discovered the correct cipher and checksum logic used to generate secrets

### License
Oracle of Secrets is licensed under the GNU General Public License version 3.

Oracle of Secrets makes use of the following libraries:
 * [OracleHack](https://github.com/kabili207/oracle-hack), licensed under the GNU Lesser General Public License version 3
 * [SemVer](https://github.com/maxhauser/semver), licensed under the MIT License