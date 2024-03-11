﻿using Microsoft.AspNetCore.Mvc;
using ProfileApplication;

namespace WebApplication1.Controllers
{
    public class HelloController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult BaiTap1()
        {
            ViewBag.Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS62GjdIP9nnofq_ZHFf6NcwK7WbM3YtlYSVw&usqp=CAU";
            ViewBag.Name = "Nguyễn Chính Tấn ";
            ViewBag.ID = "2180608006";
            ViewBag.Lives = "Lives in Hồ Chí Minh";
            ViewBag.Favorite = "Favorite anime One Piece";
            ViewBag.Character = "My favorite character";

            ViewBag.Image1= "data:image/jpeg;base64,/9j/4AAQSkZJRgABAQAAAQABAAD/2wCEAAkGBwgHBgkIBwgKCgkLDRYPDQwMDRsUFRAWIB0iIiAdHx8kKDQsJCYxJx8fLT0tMTU3Ojo6Iys/RD84QzQ5OjcBCgoKDQwNGg8PGjclHyU3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3Nzc3N//AABEIALcAwgMBIgACEQEDEQH/xAAcAAACAgMBAQAAAAAAAAAAAAAFBgQHAAIDAQj/xABKEAABAwIEBAMFBAcFBQcFAAABAgMEBREAEiExBhNBUSJhcQcUMoGRI0KhsRVSYnLB0fAkM4KS4RZTosLxNENEVHOUsiVVY3SD/8QAGgEAAwEBAQEAAAAAAAAAAAAAAgMEAQAFBv/EACoRAAMAAgICAgIBAgcAAAAAAAABAgMREiEEMRNBIlEyBXEUIzNhgZHB/9oADAMBAAIRAxEAPwCm8qlgJSkqUdgBrg9w4lxlZiyOWWlq5i05LrGQEiytx1G+xOA0VWWQ2r9rB6E+2ipNvWGQKKV+hBTf8fwxX40p9gUycGORLShkIUy4MyHFDxWOlvUYsp9qE1IguVJ9DDMdsKVn0vqDYDqSbaDpfCOzDOZta9mpGS3YDU//ABwx8RLSpTd9SlIRffQeWKmujJZY0Z9qUwiQw6h1pacyFoUFJUO4I3GIldlvQaeqZHQV8haVrbAvnReyh9CT64rXh2XNgrkyKTUIrA5l1xXXApDx75EnMk/tWHnfo2Ur2g0mTdmqpVTXQCFB+5aVbeyxpb94DErjT6G72NKJDLrIkJdHJKOYHO6LXv8ATA+kpfc4irEkk+7+BhA6EpSLn5XP1wPakU+Rw9UmoD4/RrLhQHUqORKCEqXY9QMyv6GNZHHVHiNtNRUrkzXUkmGwP7tW6syjonW9zufPAa/Ru0NSpTMR9a5LoabU0myj3udu98wwAqVVp9RSqHy3kSEKzt8xuwHU2IPb564F05Qn1KHVq9NaV4V8mPHIysk5em+ouL6fIY71dCVSUz6Vd2KyQkupN03/AFQRofXp0wcSk+wdmlNz6xo4AkOLyqS6m6VJWokKBv01J322G+F/jekU5mLBepocQjmKYdKlkc1ZGZKyNgTZR22KfQNsCMJctxxtSkgRzsdD4VAA/NYwM4xjo5rEG3gSFPLV0BVYD6bn97DN/kKZz4PeZVGcafjtJUm/2yG7IcAF72tobdP+gnorkN8GIwwZLPMAJXdKCRvbvp5DAijxLMJUklDiTZWU2I1B0+Yv8vLDRTBHqIPvcdlb6dyUBRI/WB+Wuv8ADG7SJsybnR3pzTCpIHJCbJF0nv1AxOjOsuqeb5YDyFnfe18emGgFDrV0uZtPET64hVBt2PLckRkfbKbOXsTbA75M8+U4rTDT7GeGpLSg2rLvbFBcd0j9G1RTQAXZIOdB0BsfxvY4bZHEnEMaUpHjCt8mQHTp8se0qmMV5uS5Vyr3hyxAzDwaa2/lirFjeJN0+mUKlyT0IjM5qDTIxhypqahf7dOgaSkk2ykG97W0I766Wwa4be4bnJ92r3Oae3D4UbC3Tqe/lgFX6W7BkqSkLU1nOZsarASdFHTQW16+mmA76nI6rt3SLX13w9b1rZTxm1tFzwuG+G1AO02qLSpWZJN0kagpPQdCfrjaT7LqfJaQUvAKCQM+UEHW5I28t7/LFQQp82I2hac4DycwK2h0UR4VH5m4P1xb1K4waptHj80reTyUgLT3OitNtDifLF+5exLfF6ZCr/s/gRaIQyEmQhuwdICNfO+KUntlh9bKlpcyKsCDcX8sWH7QOMkVFxyLGWl1hKTZRKgFkjQ2Oo1+V+4xW7pzEqTchZzXO+EZ/wDT1XsowS09s54zGYzHnlZuyPtk4PU+nyHIi5BZc5DgsHMhy3vtfbAKP/fIwzcKSXltOxA84llRN2kqISo26jY/TF3iroVkYx0JaZ0Mo53LnNI8QO0hCdR/jFvmMd3pJeBz6qQpV/pfA6kNoarHJWsONZSLlNgTbz/rTG0FwqcmNubhWn5HFNLQMMdYfC0t+mtt1ODSZiVAOD3nmBxskbEp0OnTbfEDiThVMSmuLdap8dgDloaiNqFz6qJJNvTTodcP9Lc59LiuHdcdBPzSMAOPm3TTY5FyylwpX5KIFif+IYimny7KdJoFey5vlRKlTSolCFNqSOyVggjX9zGI9nLcdIVDkBKnE/bsuEpF9yErTqBf1xtwFdmRVT973dtV/wB0r/nh7Qc4zfPA1bVdGpAAcHUEGCldJZX9qc6XVqeCvAs6lW+oHTDHPZR+hXYzaUIQEZEoSmwGo0A2Hpj0putm33V3/wCFQ/jjSrLLcVFvvOD+JwtU3RzSE+jzS1NeQtYA5gQ23fVZF7k76DIO3T5z+JW+c3zkrUvTKsHZQ0318hiG1TQt5MptQSOaVZstifEE9PNR+uDEtolKG1AEFISv/KNb+uKuS2I1sXoakpZIU4XFNkJURdNxrlOt/ng1Skhl3wEKsLXVrYGx7YGvRlRlB9CeYE6FNviB0IPe/wCeC9LaKUpU2CtsmwzaWPnjG0TeRvXQwNgLyrBAGXbzx5IZD7Jy5c4x0joslI65dseNNqGa+mFbJmnvtCu5GbMjmSFsLCSA2tZKVI9DfT13wXiN05qOosJjJzXuQQcLPtHgrTC96jfDfxBN/D5/gMI9BqK0S0rkLUWh4lAEi+m2mu+KpjnO0xkY3x2WZVKJS6pCeDcZoulBSFgEDUdbeeECRwY3NfU0lYbfKQUtpSFi4062sMOUJMySyj3CQ+ygq2zXAHbGzFbjt8+GtwuSWV+JaTqD6dDr0wcVU7XsneXvSKcqcKbRmlwZ/hKF5Q04nUWO6dNib7H16YfOHK3QaxQWqO883DznKUG5ykHwkG1rX3GPaxAHELc1qpAhxkBbLqwUKaJt8VxbL38/rippseRSagtl66VJVca6HzBw1vaHx/moc+IqLDoAL6oaaiyHf+0hzKm+nhISrb6HXCNUXS+W3VLHN1Ryw2EpQgWyjTe+o76ak3xbfDdLicUcNKtHWXLZXA2uwCwNFAHQX0/jiruJKLKotQEeW0ptRvYEGxt54m8nXAowW/4sEYzGYzHnFZ3hpzymk/1scHOEwpErNY2z5b264DU3Sexf9b+Bwc4Xqs5hK6cmQv3HOXVM6FN9NfwGPQ8Nfj1+xOUYkJbanuvi9hnI+WBL0pUSope1KHB9oPLviSp1TmRINk5iFHrrcj5eE/THVNOVVk5I4HvbK7hH+8uLgeu4xXk1oTGy1uB5zcujIbSrMpk233SdQfkdPlg3MiszITjElOdlwWUDpofPyxTHDNae4clNqWFe7FwpKVG2QHcHy6+Rti5HI8GrxG3HGm5LK0Zg274kH1TsfnjzMs8aLIraEs0Sp0mW6ukPh1l1OXMhSbkfqqSb2G2o/DDRAqcdllhirT4AmkeNKXk7/XfEWUwmG9licMxHG0/C4hCEj6BJ/hg3SeaqP9vDbiX2abWFWH0GuE1WxnZLRlte4ta9/LAfiCZ9qmIwMywi7h6JB2+f88TajUEQEiPGQhUxz+6bSLAftHywGpMJz3xKH1KW865meWettT8th9MdPXZiaYwMUptuCwz/AHaUJFwe10n80jECXHcbQ5DaSrPulVrlaen8jfXc4YgOY0oHfLbCHxdxpSqbyKa3MLiy+G5LraFENN2J1UN9coNr6E3wLycVsB9BxmmrNOWHkELKrixva3X643hR0pTmNyVWzK2IPXCxT+I2YtVZbprfvlwTJSwU25ffcC9yLDXrte+HSmSItQbWphtTahfM04kBSdbA226Y7HnVoRc8kSIgChmONykZ1X64jBZZfyHRJ74mLAKknphrFKdoG1yAZkFxCAkry+EK2xXy+EiqelxmGtiKhASc7gczKTruLDr+GmLSdaDjllKsOwOI3ubkZGWOpRTf4Va+uDx5eJtKoTU/YsTs8Shve73bdS2Eot+t3GK9oFVeplXS9MSX0NLJ8arFV79d74u9+FHfa5bzSbHywrVngmHLkcxrIwDoRbrh+POn0zIxqV2KvEr9P4lbUimyUsumyeUo2vrc+u2KcqsiXzktvuuLQyMiCVaBIOyfLFx8ScJSEMH3dpSXo7RCFpV8QF7AfW+Ker1GnU2a43LaUk2uD0UDr/HFHXDcgY2ubTH32S8Ufo95yFKdQhgpzAqI30+uOXttqMepzKQ5HIzoZdDluhum2K6bHKKlsc0NjwqWtNtTew02vY9ehxtKluyW2UOrzcpJCb6kAkHEubjUNj4x8b2R8ZjMZiIoOsZWR9tfbfE6kZTNQlT7TSVf947fKm/ewOnoMDCcu2NmV/z+WLfGvSF3LYcjSCp5DhOpULix/rbDTwmvJV+et3lN5dTfr9356D64R4xzKSpVuXv4j93UYb4jNHk0lh5mquQ5iFJDrT6QpBUDuk6b77nHpqeWPm0S1vlofeKKExWILFaprVr3MhCU3IPVWXrre487jtgbHq9T4cTGjQW0SGHE3THcN037pUOnoP5YM8LTpcBhcd1EeQ24q6S0/wBLa3uB+F8capSJsiSpUdqD7uRmDLslRWlV/u2RYX1J131vvjyq+0ypdM7U/jmY8jOulxwr9mWQP/hgvGrlbmtXYp8Zm+y+aXAn5WSMLVOprD+dsf2eSj+8jOafQi9x5jDXTC1T20c59oA7JGgPzOEpyvY202uiXCozn/aQpa33DdTi1eJWJ77IiIW+0krdKUoASLm19fTffyx3jy0FrltkXIzCx6dTia1y1tWAuLW88DT2hM9MV+MKvJpXCdRqKCmMsI5bQCc5zEgC5sUjfbbzG4r6iKp0iI1ES2FtLTncUtIVzFbKB31N/Xa+Gn2sz6dT+EZtPnTGhMmZfdGMmckhXboN/EdvM6FE9nkWlTmJMaqKaQp0pDKyciwpJN8qumyTa4v26YkzTtDuDsZqQafFazQYjTbRVcnVSlkKISB3J0IF7Jv9WCmviNPivNkOulaUqyHKVoWct/OxI300xoabR2HmZaoaGywACjMSMyja2QfGrfXUnphMrVYkxZfMp0jk8uSlarIIzJSRlsg6X8Oo0Oh17JmNVtGVhc9lzOspdVY/ENsdSPAdPhxXLftLkojlTlBclctCVpdZUpCZCTuW0lJ23IvcD0ODPC3tGpNfWpktPwnUKCDzrFFyoJSMw2JJAFwLk2xcrT9C1i0Namvt0ukm2W1vPHRC82N3B4cRI6in4r4L2c+vR2cv3xybN/A7qe+O4UFdMD6g6yEEczKtO1jgp/QtrslORkPtLbdSChYIt64rf2g8LMmmqdZskNgIKnfEAOnpiwqZIEmOFg3toThW9or7rNMdYUSGH9LgXIva/wCR/DDsLpXoGpXs+fzCjoU62C+HgEcsAJKSfv3P0It8++OnE9Gfo6YDUlrIt5pSxlUlQI06jtf5eeHbhPg+TLqgecjJLSFhRS/dItoQbdb4g+2eE5Bn0tBUgtlt0t5N7XTcYbn1wDmt3ornGYzGYgHk6h0tys1aLTWVBLsleRJOwNif4YZUcIVyOJNOiIeTz0hMhkptmykLAN+xFxbED2cXPHlEsP8AxP8AynH0x+jmFTBJyDOUhJP8cV+PliE1a3sh8p5dr42fMkjhWqQQbsvJN8pPLPpt/WuBd3WlFhQVe91ptqLY+sZ8AS2FNJUps3BzIsDcH/TFM8ccAykzpEslbhXmcUoJuVq3/EnfF2HMsjSnr/YXWZ49fL/2ItDqc2LLbDD7qQkXCUm4+m2GZrjmoMzPtk52+6ND9P8ApgBFpa480j7RsgkJ5nQba98RaskolKWg6FXx98UV4a9tDZzzXSHwcRs1VpxSiUOIT4FHRSVfy8ttu2ONOqUhxwIWTlHUqv8ATCMw+pBCEE3+8cMlIDqstyceT5OOU2kepgn8dstXhubJkysm9xZNvupH9HAfiv2rwKM65T+G0Coz1HKqRuwhR00tqs+lhtr0wMr8p6ncAuGMD7zU5KYtwrLZFipzXsQm3+LFaR6aG1F5SQyltwJJeXe6b2OWwFuw/hiJ3oC5XIG1afNqslc2oyVPvu3WpxSr3O1/LawHQAAbYfvZSIFQlPw6uhuQXWytpDg0JBF9O9k4U3KeapLW3To6vCglIbRqEp1KiPr56jBfgRph+M6h2a3EfbIVGdCsq2XRqFAkZcp1SQT8tsBfcbCwv8i1aLR6e7HTGmRYrjzKlNNLIBzIKlKGUbZdTpbTbFfccU2VJdf4gjr5dPEsIigActRBKQbdrg62sR64bI36YkLej1SYwgPJ8RiRrGQnb+8AtY31PTt0wP45akR+HGkOs2ZbyNNuODKScwJITc2uRfxa/u7FMNch9zuRXpsOsVH3SVEpxlQmXFFDRBdyrPxeFJudU3/HS5uXZfXFlvGuwp5becStttb608ki9wlDmhBJJsdOltMMnsslt02jx50qwaddfZKr6Ap8SfrmUPpiwktR61DH6Rd5jDTYD7VylBWUgqKjfUAHbYa3v0pvEl6IuwXwbxXCqbqqcl5RUi/u3vB+0UkfdV3I11ubgXuSFHDU6gJVzOnbCDN4X4akBEqjKnQpDSs7EuM2862CNiAbgjzTb1xIpHGj0Z39HcTpaLoByS4/wSEXsFp79jbUH7oGOmtezGuux2Go00xAdiIlKdDiLEGwIxNjOsSY7b0Z1t1pQulbagpJ9CMKPHPHcPhmI81CUxIqh0Qha/A0TqM9tb/sjU+Q1wzml2Ap2GlvRaCwQtxSi5ctsJ8S123yjttc6AdcV9xb7QnUJKBHpkyGb81gqXmA6Wd0Fz5DTz3xXFaq1enL95kuTZQlkLLy8yUZh9xOW22ul9NdBfBjhlUqMw3VFNtNPFxDKGFtOOrkIJupTIP3gBqQTa2E1kpvkmNUIYWvazGRCT+i+Fy0+oA/aSBkB6agZlfhhB4/4gncQT46qkxHZWwlQAYbUkKCrG5CicPdTjUpuOqp1CKkkmyh7qW1Hpqm+/r064r/AI7lGoVdFQIXklJJSVgC+XwkWB0At/QwOPPWRg8FL2LWMxmMw40ZvZppx/RP/wBn/lOPqNaCbFJx8r+z/N/tpRyk+L3jf5HH1HT3s7WVZurDJT1sjzXLyrGyKJLzTwDwyg7E6YmpLEti5AWnzGIdRCRFdefeYZaQLl11QSlI7knbFIe0Pitc7l0mhS3X4TIK5DrayEuK6AHTMkC57EnyBwd1Knl9k+NX8nDW5Y9cSUIypKvcYCj1KwOvlhFrHDlXbc5DVIJzkfa8vMRr0wpvNLjUtBKYqFKAUlQa5itdbaiwGIcypTIclceO+81y1WGQ5Srz0/0xTi/qtpcdbGY/6e4e0w4nh6psSVplQX2xc/EgjrhqoFCedCnXskdhpOZ2Q8rIhsdyTpbCXTeJeJg+hDXEk5pXLvkVIUtIGuhSdL27Y84jrVbrtKbdnVZyVHbVdMdSQmwvq4UoAGhsNbkZrbYiyZvkez1YyVMaDHGHGEGo1OJTqao/oenpVkdKDd5xWhXbcJ0sB/PQdQaRP4trLMGIQjN4szh8DSANSe5t239MJzZsq5274sPguXMoxaqDLDpJNwttGbKbEWIGtrE39Thc4+dC9tlx0GhUbgiEluOl0vOkJckhpS1u+WgNh2H5m+AI4aYovEEmt0VKmIchOaRGcbcZBub3TnASCDqBcAglNhvg7R+L11JoFqlSARopa3EtIH+cg29AfniYxWnpz64sF+M4+2MziWUlxDXbM4bDpsATv2wVRpaZqfF7QNalNvJiuR15mXypIN9zlJOnfTrrhG9qlQDlLbjIV9n70EHKbZlpBzZk22T4bHurpY3eKhQnfeUqIfLynOapdOiIQhxWUpuvMogmx3IBNhrbCD7SeGa7IcpyYkCQ7EjsltFmyS0pStVLIWu9xa6r9DfzRGHjex9ZtyHeFKKpz2UNe9JvzX1SE208KlFOb6HNjfhmY69w5BizF8wT6wttwqJAUEZl2PqpCRbaxtrh4ajQWqDGpjDiDDXFERtaFAg+EITY9cUU/WpcZn3W+csu+9oQFkFs2KV5fxOKaTqGvsRGt9l9IWTqTr164XeM6MzUIPOCUpWpwXX+qs6IUbdzZKv2VXucibAODa9WKvMS0642yoMXzPoKs4vpaxFz8WtxbXfWzap6XIedguCBdLOdYK1qK0qzAeHTLcgi+ZR02xDL/ZTcpopyJU344kx4U2TCcX4H223FNqPSxAOqul9+mJfD0ioQZKI9OkQWG15lhx5CUrTpqAtVzr27n1OOfHPCdTjvzqy3FT7vzbOlp1Kyg2FzYba9dL7lKb2wlIqU2OAC8Fp//Jr+HTBOG/RGk4ZYE6k1NgzZbjctK3wXHpLDpuq3W6DsP6FscKTW6aX2WZ9LecCCCzOebSp5u2ozK3URbtuNB2F8IsVCuzGvduH3ZzPMSXFspyoIuM3jOg0874saj+zR1Jbe4hnWCtPdoScw1B+Jahr8ki3Q9cZ8VUtUbWR/oWuJK1SXmeQG/fCpXhsChObproT8vriv+JIEuCqN75FXHLyVKQHE5VEA9U/EN+o13xbVcjy6RNficKUURG0NhPvLbRU84CB99Wuh88VNxUia3UEInqUXVIucyrnXX8O3lijH4045O7f5MC4zGYzBHB/gJ2PG4ypL0x9EeO29dbq1AJSMp1JOgx9FU3iDh5wqQzxBS1qH6spB/jj5jos1dNqsaczlLkdzmAqOhOuHhHtBgyiEVGCUhahdxtmPcC/flX/HD8UXcvRLmxxVq6XoYPbZXluSotObczQUtJfASrwPqN7KuNwANOlyewOK3pFTiNzQZYSEHQKJzBKtNf8AUYMcQ1GPGrCjBpsGXDW0hbQlRyqwKdR4SkaG/wCGI1OqiZkxCHKNQ2kkpStS2HAhAJtmNnAbeL08sTXEtuWx8cXpokSZ8OahyM3NSgrBBWFWv3sdsCJMQc7lsSEtxUpstbjqbk977+VttOmGiuCUZ64VM4bptXYbs2lyBBkcu4t4k2cPpfY221xzl8O1YRUuz+FqTRmFrsHpUlSMyiNEhOcrJ7JCb/kRnEl9jNipImx2UohRnSppF/GLHMq99e/0xN4anwck2O8WwXEjIpakILiRe7eZfwpN9f8ACO+CEmq8NQI3uop7MmS3bMllp4IUoXzBa3FJVrfXwfTqMHEdPSNOF4fxf+Yd73y77bjvYnW9iDUI7YEmxER5jzDDqHWj8DqVXBB2+fQ4a6dXm4iQgOMlJ1KFGxB9emJTblNlU3nRKbTmLgpCi28taSFbC7lr2O48rkaXHqiRg2E+5RUi/iVlcKl77+P8rYfiVL0doYadWokmQUy58GM2nVSi5mCfSxutXknS+6hh64Q4z4XhMPx1T40RAcHLBVdTum6rDVZPlYaAaDFc0piLIe5Ro1K5QGZavd1KtqD1WeunpfpiwOFeE6RNYEl+Aw2lsEBxEVrIANyc6TmV52073220/s0Y5HtG4Qjq/tFbYB/VDTij+CcLE/2rxJaFmnSIsGNcpS9LivPKc72QgAAeqj6DFecQyqBH4jdRQ8rsMKIcmutNKCnO6AEABA2vbX0tiwuH5NEmR4wS40y+hICWltMgeqTkFx21via6UrsOMfL0BpHtApjbKmY81a1lRdIZadSkqIylSQ5qgi9wMyhodEn4ktVMmcSSp8qmOMkoVmyFwpXlOugA7qUN/wAxi7WKJCYUvltqQpasy8iyPF8sKPtD4ZrEpv36kTZEltsXMB1zNkP6zV9+5Tv2PTAfMmtJhvE57YC4bmSYdZoslWRFO5y4qU5gCgqF1Ai37J66a98Wa3NhDiBbiZLBDkRCSsOC3gWrr/8A0xRYlKje7NtuZUtuqc/vswQs7lSPuq31317A3ltcQyxIU5y23EqTkTbtc69O+FuG/Qc1K9suZl9TUCSYrjaZD9SUgXF9C/lJt+7m+mF6o1KiUWtT2FRYDTnPC0rTGj5vElKviX1uon54UqW3IqQbMGfEfLalFbJQoOi+68hGtsx0BI13x09oVIp0KVTpdKcWtmfFUVZz4uY0RnUq+x1Gg2ym1sMWOhd1P0Mr/FfE0lxIoSau/DNil5mC0tA3BSFIQQbH0xEMn2mSW/DBqROniW+hq+nqj+rbdVPh3iur8Oyw/S3EKTYe8Q1JAbfH61hsq2mYa7bgYt2h8R0vjOMtEZxyJUCkKdhvK8Wn3k9FJ8x8wMMjW9Nk13pfihEqUDjdEULqJQhorSVNSqkF6g7j7S2n8+uEz2hy0y58bxR1LQlWYRxZtI0skfME9hfTF48R8JtVZkhDwSUtkBBv64+e+Kac9SqmqPJbUhViU5uuKLxQp5JgY8vL8X7A2MxmMwgaSadHMqoMRwCvmrSmwG98MPFvBsnh9DSnihxCvgWi4zfh6Y5ezVCV8eUNtVin3oZgRcbHTDzx1X67H4jcpLzkd1GdSm2XYTbxQgnw3KCSNO9jinD5E451S6J8uPK7Th+hJ4Tfquf7FEZMVBAXImNpytJ7lSthrsMPCfaRHo4CIUdVSeQdSy2llnfoq1zt+qMItaj8QTpiFORnHGUH7NtMYhtF77JTt+JN9cSVIqsWOhkUNiSjJdTnuD1l+ebLr6/9AvJ5ba4rWjv8KqfKh+j+2yWB9vw22U/rJn/wyYrPi2uVXimsGoVV5NwClllsnKynskfx6/lC98dVmPuTaT3Klfh+WPff/s8qYcMq6qL9+/f0/LE26HpMj+6IQ3d0KINiLaX/AK749iw1yH2mY7JW86oobQNR/QsTfG4Q8olyQthIGti+gaDewvp5afLBSDxFHpDqZFPpTfOLSm1LkT0u3uUm4AAy7EWG9/LBSu+wtD9QOApTsZrO046Eoy3CsiD1366kn1wWkez5lhCTLkRI2c2BL6r37AW1whr9pPEDsYsskISlISECYAnyAy2PyvgQeLuKJTqmYk33V1whJXHWltZ9XPjP+bD/AJNejey46XwpDo7Idfb56R1lLEdq4/WUrxH/AC2wP4mrFFqERUOscW09qHYAwabdSVDsVAi/pcDyxRs12e9KD0iU687fR5cjMs/O5tjV1Et7LzVBzL8OZ8G344zk2d2P0iFQnW0roUV11AuESXvsxp5rV+WNmKSgXyzoIWU6kTEtoQepOYgH1P0wkJTNiwgtLpbRmNkCQPnsq/XHSPJkSEKWUslLaSoqdcBJ8tTc4Lc0uwl16Ht6t1LhvIhNZjy2vvNxZHNDafO10J+R+Q3xPEtyrq98ceQ8gNlx11w6IQnfT+GmK0D8l4DMmKoj7qnU2/y38vxGuHnhePT2URDDnP8A9pCkzIzyQsf3arpSQBpubdfDfraPPjie5HRka6GCmcIM1x1E2WhCIy1FPPzAqeKTbwC9gNNyL6bdQda4K4ZMeZDbpYffaIzFbikrUopBSAsEED069DueNKmg8Ph6S21FdhT21+7qVohPhz22vdK1nbriXIrUOFxSt5pznokwwhQbNxnbVoR8nN/LCVTD1y+hQ404UpzNAh17hthbcdCAX0haiUpNrL1NwUnQ7b+WEl6VIkBAfecdDZVkDhzam1/Mk5U79sWQ7xMmFBrjbLDa4nOWEx3RfVablAHmpdrf64qxL6eSUCC6pVgnOXlApIve4vYnbpuPkaMdNrQjLPFnY+JV9lXvcd8FaS62JjZ94chSQsKadQbJ5ncndBN9xob69sB0vr8SU01tCVWynmqVk1O11G9+ua+nawOJMtxTkxaoEWMhpRSpPNbRnTb5G1zfQG21xoBg6jYl6LsoPEZmNpjViTHbqDenNUrIl236w2SvrbYiyk9QK69ujTyKjSVSeWoqZdLakbFOZNteu+JvBLNUgo/SclcURVqWsthNwMpKj4cunwqItbQi2Bntnqqam/RlBpacrT2ReQpS4kqTZab67gjXXS/bGzleuLJ5wY+fyJlbYzGYzHFBLpc+TTKizOgvcqUyrM25bNlNraA+Rw30z3mlQ01GUky5c1QU5zXcuRNiStSiDfzJ30GvVNpyQ5OjJULgugEdxhknpafXJDtoy3HkL5Up7JzmkgiwJ+EZrkDpYfJV9vTDjrsKUqSzX58uKalKbXKCloPKAaBCT4e4TlSb7Xy7a2J1/iWaqntth2M0t5sFCY3/AIdu1wM1z4yO3w277J1KZMFleQ852S2Uh5OjaGzfME31JOgvbUG3W+HDgnhhutyXFSgRS44yujOUl1Z+5mFiN7k3vt3uFPFyrS7BvIpXYnSVzZzjUGlMSHC6S2jlIJLxAAIT5C4ufPtvZvs+9nkOmqRPrRZmVNFlNR75mo5vv+0sd9h0vviQ4YfC7simUujx4aHQAl9vMHFjzWblXoe+GfhNko+0tcq8749ZeF8eL5K/4JazOkuIXil8SOVILa+vwDbEyUYUWMp6UY7LSficcypSPUnA+RUlPvLj0hpuQ8hWVx9ZPJZPUFQ+JQ/VT21Kb3x4xRGi+mXUnVzpSfhU+BlR+4geFP4m25xK9MdCa9i3xHTIvFccswaGl0EBCpryCxmSCfCnZRGp30FyRfAF72Y091P/ANToWRsaBdMkALR5lJAzficWtdPhsP3bkYzMrsMZsPbKOlexhmSCuh1Nt5F9W3btrR5KBB18jbCfxZwLU+FxGXMaAZfWUpdKgoZgL28J0uL/AEOPpWbAZlJ8QW24PheaVlWj0I6DsdMKHGFIq0qjyYE1aahCIBDyUhLzJB8KuxI3ve3lgkzdsqvgbgdziZpxceRGQ5HWEuhxXiSDcghNibH5ag4seD7K6VCCDKQupPnoo8pkeZsSfofUYq/hesy+EOI0SwhQDCyzMZGnNbv4tO+mYfLvj6SiSmJkRmWw6HI7zYW26NlJOCptdHbYFgcKwY6ENlLaGh4hHiN8lsH0GpPmTr1ws+0GlNw6tSKlTojYVHadQW2Ra7hH2YyjoSpe2HSbVo7KS1Gd50lRyoShPMJJ8h0HqPXGlKpi2XzMl6ylXHiIUpIPdX8Bp6nXCalNaZyehLpHAbtWhNv1qTUYzzif7ShJbQHLeFNgE+GyQkE6Xtt1x2k+yiM8kuiu1AS0ght1SEFIHYptr02I+WLFx7jOMoL5L/ZWnDnBj3DVfYmTmEOxmQq0pGZ4qWrYlFroVf7wBAFxfXDVVOHeGq6379NpsWVzBpJZ0WR/6iDc/XDABoOt9wdsQnae2H1SYv2EhQOYp+BZI0zoBAV+em4xqSXoGm69lc1nhvheiOIUzQFPIWnRbs19QHlYrIwvqg8N1KWmNHjqpMt02bdS6txpSugUlR0B7gg+uLRnRkT466bNZEeS4FckjxNuaXuhX420It1Avio26Q+7VXxIUlhERzK8tasuW19r7kkaeoxRETR3KPjrl1oZ6bHfi02sw1IQzKjOJdQhRzALCbi/koo07g674rT2iOB2fEWk3Ry/s7nZFkBNvRNvzxa7M0TGXZikhGeOyHM2qiAp0AE9T/HFP8bPXmw4oSlRiRm0B9ItzUlCFDw7DKDlv1AF9sTUuOVyQeBac1oW8ZjMZgi4k05WSoR1/qug/K+HGY7T21PiUUhx1GRZ1Kko7abdcI7SilQV1Tgk2XJRC1KupXxE9/5YTc7ezeWgvB97q9cYjwEeN1QZZatokdL/AJk+Xliy36ZNgD9GNynI0ZhP2RUCnmr+8skb5jc+QtiN7FaEhhUivTUAAK93i37n41f8v+bFnS4jcsKZkAOZr5Tb4b9jizxGsT5aIvI/Ir9p6XXYsZ6atLYjpUHpCkAIFupVsBtf+OGejxnqoyEM8yJSQPEsAoemep3Qj08XmNRhcrUuHF4jhcNcy0COQ7J6ZnVEGxPkg3/xX3AIsxrlpYShoJQi3httbDvIzu0pXSHYcbmezRhtqM2lmO0ltpCQlKEAJSkDoPLG5ONce4jHAuuVxqkJSHWlKUpN7kZUD1PfywtM8Zu1DWO+w0lPhBBTf1AJOHo2UNQT5E6YiSKTTpmsunw3/wD1GEq/MYJUjhVNem/+dR9EfyxGlcRlLa0Saq0EqFlBa04blcOUP/7PA/8AbI/ljg/IodEUGkMxmnt0sRWAXD/hSLjBcl+jdlI8bxGXpH6ThHOhQCXVAHL6g9d/xwyeySWiqF2hVCU6OSjnRUBV7pJ8aRfsSD/iPbE7i0OPxnGpMX3Vp0kpEhd1qB3AQL30O99LbYralTZFBrLEpKlodiOnmZbgqT8Kxodykn8MNa3Jx9G56RREAOPRoebfmOJCl+pJufqcRXOL6I2FWkOOqSL+Bheo9bAYgxKCXmw6hEdtDgCkrABzX2Om+CH+y0B1CEyUqeANyE+AE6a3Fj+P1wnU/ZhFa40iSHuTFp8992/woQgkjvbPcD5YY2lFbaFqbU2Sm+RVrpPY20v6Y5RIUaGzyYUdthG+RpOUX76dcSMC2jjzGY0dcbabU46tKG0i6lKNgB3viNFqTExwiKVOIQm6nAPCD5X1OMOOs2M3MjKjvAkL1SpOhSQbhQPcGxHpireMkzKjJhAICuYPtW2k6F0eFSvw+QGLIrdUZo1LkTpJ0QLJT1UrokfPFaLqTql05CxeQ82ha0jotfi0+ZxZ4Ubptnjf1bO4UxPv7/sCOOpLlHSmkR3ynKwkPFPVQBV9PGcJnHj0dx6A0wUFxpCkPBIt4hlGvyH4YYOPi4ucuU6kFa76X1KU+FN+1wAcI9ZUVvhSzdZKifO5viCu8rbLfCcvEnKB2MxmMwZYdYrBkSG2U7q/lfBvhWXIp9UiuU8BUsSEhlKxcLWTYA373A+fTfA6hpWatFQ3a61lIJ80kYYfZ9HSeJVyXlhpuA0uSpbgsAoDKga9cygfljNcqSE3XGmXu8pNPQ1FjqbQWwVENiwzKN1ED1JPzx3olXD/ALyZRQkR051LBuLd8UlPrkwyw0JxIWdFhZVa/THan1upU3h2qTUvDnTClloOm6SAcyjbrpdP+Md8ejkiIxaJ5iuXJmV18Lrs2Yh8PPPSC8pWQp5auqNdwn4b9QMXRwfJW/w+xzD8BUjXUkA3H4EY+Y2qjUEG6lokJUbkEb63x9E+zOsMVnhZMxhaQovKS4gWzNqFvCbd9D874kqk50i8bce77Y1Kgm2YgX2viHVKrBpbJcnPIbTa6Uq1JHpheu9HE/t54GVGtxILoYAXIl/7hnVX+Lon569r4htrqNfjZmS9TYTmuY6PuDt+xfvvgnTaZDprXLiMJSNlKt4lHqSfPG60YDVNVWoILtRkJp0UalphfiPqvQ/S3ocQRHk2W1QozdOhjVdQeALi/NIOg9Tc+XXDDIjs6yZywoN6hKvgR6DqfP6WwGJkcSvqQ2pTFLaJStxJsp0jQpT6dT8hrqNT0cK0iI28681TE8290v1CQSpZV1Cb3urpvYdddMVZVn4zlYktxbkNpTnUfvLAsfyHzxbXtZrLPDNEiMU4JZlPNrajJbH92gDVfla+nmQemKKpbCklUg3CCopsTuO9/XDJrs0vvgPiGRI4ShspKUuRQY61DU2T8P8AwlODzD8l91KC444pWhTnIBGK49k63ZEioQGkXUoIeRroN0m//Bi1HJFK4Zhl+rTo0UKFit1zID5JB39MDaSZiC8dvltoQFFQQm1z1wCq/EbdPLjMdozZebLymj4WyP1ld/IXP54UpXtJpNZdMOm1B1mOV5StDDvMc+YTdI9NTptsda5WI3D9KaVQkIlynF8psj4Uq7EaWsbeHS532xsQtbZLlzpXxXsKf2yeQ/W5jTTaV6qXZDLB7JB3Prc+gwztPwKdSjJQVe6NC5WlCiVX0v5374rJ3h+XT0M1WptrrdTSsF3mvBDMdFrqyi6Rbpba5vbphqh8cwKnRJkpuMExoqSCF+JJOW9tt9vqMT1llra9FO+hU454hZ4qrcek0mRnbQm2UpUnxnc6joPwzd8TJdRiUatT1MthwQmFF+QoX8Q+FCRf9awxXNLW7UuMo7tPQAhiUiXLWk2SEoXm6D0AHc+V8GeO3f0eh+MpRD1RmLeWT/uUK8I+atv3Dh6zalpEL8WLrlfsXqhUXZriEc51bitFLUTmUALW/AaXtr2wN4jjriiKy64C6lC7tAn7LUaHzPXtjePMZiVAOsPBeTxIWpHUai41sdB1Iv1IxnFMByCYhfcPvTzanHmTqtoXGUK/aO9unXXCZl90xsJxalegFjMZjMaVEmm6VGP4iFcywI6HFlUWCzL4errrSckqbkaIGxyeJR8r50/THmMxT40p5UeZ51vHSqfev/RH4bpsmtVlunRkhTqleLUAee+O/G9VjypbMKKhxlqnhTTayb50kDxW6E799QD8OPMZjfKb5aL570DIBWw6H3XcyE+Lbt1we4e4nq9PTMg0SSYoqryAt2+rZudu184uRqALDXXGYzEi9jTWsNUgDOpyXNeXo5MlrJKh+yLXA9STgvwfROHpr7Tcevzok7PmQuMhSUZwL2AtrYdSR122xmMwmqpRtMEfKZxvVqDW2KRxQ4iZCknKxUEJyuX/AG0jcXIGm191dNHvaZVaqiW9wvSI3uUa3MmVBdx5fZpIPpv52x5jMHFN4uR2yB/tfxPU4fvtXpMVdLjOf2gw3uUSLXtqonqNvPYm4snhviCnVanqVBQphEVKQ7HU2E8kWuBppaw6fTHmMwz6NPn/AI2rjvFVccnhSg06sIjJV/3bQvl07m+Y+ZOIS0JREIQLJbGZI72N/wAcZjMUaSaNkI0LiWRwrNdqENKFvOMKjgOC4TcpVmtsTdGgOlzgbMem1WrMmokzqjKNkh5fhHqevXyHTHmMwrN/ID6LPotMdpVOUKpFp6EIF1usNAK6WCSBe1t9vnrgQulR59AqshC3I6OcG49rK31srroPPr1xmMx1NxHR8xjun5O3+zu3watdNRJ4k4inSoyGkvKauqwFgdSSom3kL9sLvF3FURylihcLxSzF8JU5bJcDxeEX7m+Y649xmIML+R7o+mntgvg6rxqT77Eehuh+SwW87agSL316aXI0vhu4m4SqfFNUfrclYZRIye7tXBCGSPAN99Qbd1HbGYzFcSuf9wMv8GyNFpdK4RlNreZVKmt5SM2oQruNrn8vPQ4TeMHY0iopfjpdSty6nOarNqdunrj3GY9bLjnH4z4r9HleHkqsytvsX8ZjMZjyj2z/2Q==";
            ViewBag.Image2 = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR9kkerbEsWhRR5Fl59pHfRde54iXaHASzNRw&usqp=CAU";
            ViewBag.Image3 = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRFU5a8CxKGXGAEPFhGcrKlACYLblKVYjT3PA&usqp=CAU";
            ViewBag.Image4 = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT8FyzrYChO7V8lV4JYri2GoRKZNGAtUGN39A&usqp=CAU";
            return View();
        }

        public IActionResult BaiTap2() {
            var SanPham = new SanPhamViewModel()
            {
                TenSanPham = "IPHONE 15 Pro Max 1TB",
                GiaBan = 44990000 ,
                Anh = "data:image/jpeg;base64,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"
            };

            return View(SanPham);
        }
    }
}
