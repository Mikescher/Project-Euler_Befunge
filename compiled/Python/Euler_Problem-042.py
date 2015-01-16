# compiled with BefunCompile v1.0.3 (c) 2015
# execute with at least Python3
from random import randint
import gzip, base64
_g="Ah+LCAAAAAAABAAVmHk4lN8bxpM0lhhly/ZSQowtu7xCKlpkRJbC2IpkJ96xjSEpYbJlKbtK38SQLBnbVGMpZlrIOkyDUbZZLNl/fu+/573Oda5z38/z3J8j95h33/+/A/taC11xso0ZD3Z7H9W1SIgTgFF82lGBY/OBEQZ6/nWfcWd0HmSMG4//7XVcZ908vyppdEH3qcifw8IK2P2mhuPWdU4rgzdzv4Rh4pq31kV20eLKmDN6ZAqhE+0ImBc1zi89fh9zdO3LErg4Wry73r07cR7qSsZMvvnyS7Nto0YCRSC0RK/9/bzzu6tmieratsmSXmdITPSaLrZlYWI42+Mt7bGg5qjWmU0r0z9ytPOoxyu7W1nolfHx0RrUTqUpvasGFcfqc8z98rhFwvTLblP0ZrGmhqbbjtru9JtIue0xzdu6WeNj/7DtO5u721uri6OYnUhULOfzlxoMgbC1sTAeKbe7Q/q2SI7RKt7AsUN3JlHtHzZpi+Pjb+QWqXGYtdUFHPtA+9aPYsz6hAQmljX9BRf3oJ3W3POAgaFNUMe3S3ALyTumu+VLCXLbhzAfH48GEmERee2YdYenxPE1dhmVGrt7dYfzuRGznmvW/vtFT9L0xL/ILVu3bSY95sXj9dBI9EpuULtvEFNusPOmszRq5w+81VKnuv/Mu4/PMSNhraDJEGp34IvpMmRDXZ1X5vza3Yl0Gw6CAjfsd6tx9NbXGthNRt5vnbltHWZHXxXH5ZDa0lruR+UZEwmt2Cg3vaKycUjOcNwUFnQ2t4Uts55EhX4ai7pFaZT8Wyb08eRe1v5qdx1oLs9XyaSVMP/zQSebL8F7EbdLHxLDJsl3CVfYM8NN99lqktd4bX6jM3MPSWILmp2YK/fcHg5xDUGOWUqzVtqPQ9z/DaPzbwqP9a9/ElAQF4wAonbUD1eoaDqzBfWpnMY1my833x5TiAp/F0gQnMl4ZUFPu6gfkMro/BLA+IzoHT0OgbyaB8Mxh4GcuwuEE9KHIuX5yOoIqG0zFbAi3QV98ScKmINOuWJYPeoAmLk+KOgG71WgkxeaQ7t8JjM6Y+iSu3myq5/ztE5r/9bjSs9NGKVs3eNlY0Ml5Wi16+vCX/hvH7rS7ahtzuq8xGLQBTNSlYkKUiV8NVUuRi7o0MlrurQFpdL1BNf4yQexdFsxI5pzuKkd0NyuCziyhYsiFexljNFTQqqE2e5/Lzj41KfMa7oKkShbatFzFUrsFXRJ/Fn9dxNZTXGe1GvfYh4yO8LfMCmh5czJLZ8RSjzlRPOZJyvtJ5IPO/0wQo/t5B95Qz5b3kkKo3MyV236LTg97otVnEUPav9fydCG0X1/5+4n/7WWxhlz5SRTd0PTFcQLWxkea8nPFePMkUto41fduvMseYL6TOz77E9j2fupDleBplsC5MCS43ZoX7ASRJaogY5/P01/uXzR24bY89ETaadsqT+Vf2PQaoYshbsbr5UcsrNWcMFUhax0zcsn/aFqXqrfKQ+goNjsDZwY7b2SlyhJmTAoeRXNUHcXum02kNKrMHCsl+OL6donsHHQiSIPQib4DXJnyR/v6Vh8824Yqzt7UJ7rZB5AODQfcgJc5RYDohIl3NQDq3++1B/6Zh/Mx6+ZuV7USWS8LbyW6tLnhw87wU3t1PBtt6PzXEXqDg3IaDj4ZR0uUlBI6Yzy8cmDiU/dT+Yvy7FcjTyk3/3ok6JLjkGiLDOxL/2LkD4Q0yZRz+UIOd5tlo3G4w6Pk2Vi2u8xY0VMZLOTX85lwxZv93oJhCb6iNxIxOlqZspdoWMle7Am1KTkXpimhTeHQ/Qi31y+awuMCCEI3TMwrwLKP8WyrkT20Fb+nnhYJmDoRK/dvm7hue10cGFhXzvlmHNi0RJfayA/2bpiOpXZHf6Q3b0aN126TbNI8U2yg3wxf5HTnBMTqHtAbFEvt2l+qVI9Pa6yqsMF0ohP8aXVshbDAteKk2BdImqL2gXmbRKL+en4OE/d0cCxhLfrh/WXhalTSldrTAtk7RERVN4NWwGyGN485v6KpsKzONs9aZBAviYSeFUE/fYQdCBensrQJW6o0UrXiw4HUg4D+RrIItfjaz14v+M0Z8O42tITbPAa8M8sx7FT9nb96yeSLVldC78Qz3D2gGSnLpXEM0zkUEOFDhIVpufTLGdMcyTUmorf3lbm0SL+iANT/30KaxY+GzZdO/FYzzjZDvjPR5g6c2Ex/leIj/e2OeR7Bu2icBp+Hso4ZNb1Xkm7RM71+AJKqiawGflqcjZlk+8nIrO5qt9YBu0haWJsbgZVbD9mqhXQrgNSKAQ83EnGxA/+lhAwGUy0wCX3W0wUD35sFjPcuNTW9uXoxUan6Yxx3t5nPqHu5KPfgpHouvIQID8NttH+HPyKfMXqEChhNs00kUYPShia1vUrFCsPC45CFa7+jBffbFsa2C79kxujFK7awq5WYj9iKKMCDC1qZPtNyvywASL+iFKv9jf5gnj3AbRG4lxsY5L0n7dg0CmjbyK4D3XhwK+sEsLRJhEkWkwNSj21fERvuYfAsN18xTQz7SdxK/Yqw8PUbYtg24bGuFQy8dPCYKHjt83beQG/ZcxyGEp5sP54ZFHkmIAoNbNjZx+NR1/uOzQVRV61/nyGQroM06fYo4XmO1pZJzPWRXCPlbWNJs+iPwfz5ZEui93E9r6R3ogV/z7RwrJqLWMOxRQyAacigeeMJLaVxb9+un4eKczihfZBGzAQo6KSEPX5qFCo2Vn6i1QxkNT0biP3ZO7N+rjs1Ye3LKQ0a1l6o2Q1sN7jdmrOAOKvbhCyVK+OvmCMm19CAk0feYMsVzJqleyDVMHVaKPuhQ3t/yYOrYM5XS9gOQalK7+nkFgs22XfCqen9OAm8ceMkEbx3mZypSyXl9rVXilVboafEVI2JeMjxDdt9njz95yOKIxiCy5bmQXmY/6A1abXoatunkniW05hj7zjhFeVC75eSA8TcXPq3veWc3ymTC///sazqy+P5iX/NVW2yxX7WX5lHiJ88R7muku02DysNJhuB3FvJPHDx/HKxlJ1Hy2g2RiB6RC/ZyROxU5Ynbggr7JxFj3COOg3P4moMCp3Gi7qax1x0Rsz4N2qoOObNU7hyyE+Lv9Pr6Q0pdfuPPe9k9biomQDauCRoYljYDiVwFR1huf5E2/XRroBWfSXnhHU9IASIvf4TWPcsqkIED1Rj450j1cnZHbkH8pSf6BLmAUDZ18x/UeantypS17JEEDveUmeD74iUCBj3AGF6vz3q52F30xk6hanckrUA0K5BjSthXJECkENDwr6ufklxnmN3T91w5H9OlZQ+ahJhLwKLvvhyZoEMXpW17SyS0PFdAMzAj4zm5SM7hmHNIKNC9hWJuGMEOVPU0L6GHVQFyOr8j3NsuhCmuNF7jyVOk7+qyZnEnqNpDBRxFY1WnzB6k4YE62Z7ShSkQxvq2F3P4qxq3uwvPu8+/YMKQx7Zcja/3Qzp5tzDNvzgvRmlutUZ9TXR7IMdTBiknHfIUxD4i6FZSQxuNDIMmscIlmQb9JKNxSbrxizsTfwv9amOudwAz9GTj1oCmHFMEJwP8t+VOcwKJsvC1Vn3v6Dg1ZP7zAk+8iRgETiGVaJtT2U4R9cL/CsGC8k6xhXG1fnfc7Ddm2OZLGd+taH4aG6pIo61EA1eNyfVTfaJoVPtIOA7L3ivhoSxcbLvuQ0KZ4El4l3uE+73YRGaOT3T0p/k0nv3MPHoTvHfkU7IbdjGM5qf7w+3g3dFHWrEsjTwh/LWvhKVHjlUUQwMVJNsV1S+4fmxwlAOY4d3MSyRZNeY5cULuNJzGeLQOaq9XlpQ2kcAdf6Ot1uiV9TsV4+kOMbEYrpaRm4o/8TUW80J54YW64vwQe5vkwfUwaW01Rx8z4Op3oPHlngErIxQXt32qK9ecpYHeqjdRF305JJIr3Sv8+dktYMNagjIRANJ+bNr3oJUxOPTW/0jnavYwphJA5RQRCx8NG3FUbvhIW74NgO70/+hiKqvE0WzV+phOrxbuI/cC374OFTug+yYIElabCDV1Y9fOZ+pFku/vqLmtSCE0ncl+MLLRc1W6zTbwoXwgZx2V3VMJt+gTugrttI7AERAtFCbEYZDu7y38i8C4abiD4zw/jSFL9TbNERdH7h1YyBXPKDcB9fkNEc0tNrwVPdqyAyU9g1PuHzc/sFp3t/NZMSU7jnuRYmsnXHH9xq9a9rD7YG0pLb2tN07gaCDagLkHe0Fz1DcmN4Siz7hyr8zK6TybJ/utNFYMxMCQwHPl4peB0BRJ/hxVUF9UfoVFDDG3w3N29FiBcy9FtuKRro7lmqczgDdZleO0dGr8YoJzuOQ+5mleD3dgLHcDuTiTRvYVM4XNdzDYDTqAvjk6dYzvSMlnv0zk3ns9wbkrHRvV6b33zWOtjgaLBptL57gcndEkVQd/I68AFTtniM+Fgh3+1IkeWE+17ZbMkoSLd/6l7UJEp3yCx9HeGowNWf8JEzuSWzLQ+KEm+qffGi69AyJK5OlzJsrzhmNakHpOtdKaF9Tb2a9ZegElpcyaTaB8u/ZVIEPlV5GjA/FYr8Y5+GL+Tm250P8g5LmuMS68c4aBtXghS1Vs4Q1HgwvGTUReTG5HPEjZ0WtYqm9yz9ZYLrCeiYsaqEBfVlTld/sdtk1G7ZQS33+Fg23qSF0xQJsfEint+G7HwKtJsEoobtiy77grX41encz9I/4XFYRqRaRuFuG/6POa00VJBWaxr8jXb9eWvfrYtjakv9XrLP7n3QlxTmh6tDaiplBuLTGdyS95MHu7It/ypnW/KP5Ka8/JKUnM44AkRtt1QFt3/22zrEoUCeev4759EVnrZ98oYF7NVCcF+OJRCPcP5qhPbeH57EOfbGY8kLgfglUeTRLnEXRLfVBGOS2d2QZxKsjXfJbE1HoLhxsJwz4PBdporl1CpoKEUjfRE/xOeo/1wC+NMwjp5dF1qrqRJSX0PAd84MR+UwL10JrKirLuyKLUFU+aBoW9XMoW21KAMsZ+FX9+CrX1YfUAjNUu4ng3mRXU6dxWDUtph9R33Z+FIaDKNJ5DbQm85Yn8uxJiPg7yvcEMbwsLfPG0o4lLkWJtvsJSR74TQ6S3FhPFsi5VltPLF0AEZTx9aHEbrvVc0QVfLGSH0OLazupwGNARGhLkc2H8Fcf483lAvFEjlCz92rQO1dFUIevw9fCN22Bon23jcCDXvoKCQlb/xQ1UxQfJOVzFfvpNfCJolfiwdRndmhjBCDE7RSyaM0xbtNsjOk8uMbWcqaT4yeuuSprdKvFl0VnlzN7ckUOu5no5tQcHBaNpD4QJXfZgme1/mzh76I8VgVq6Lxwxfil0CtNiGh5y8hegh3ggvk2oMN1PCuP/sWvIZEgMyIn+gK70voansNVDC7aUWj5d70jQJj3JxyyOkamS0zV3dGli4w9KQa/E7bO4MnVRr3IUMP8H0dxV5+bF6S1qh8OQ28S/joUd1HtDBWTcr9bd+zXcWqVCclWTjKDUbsFnVtdfQrkNs/ZqTE0s7bzJiKGG6Zo6ue20DAglmokWP9Tlfvo/s+tp2vEfMwBfAaNQotCxMahPx5zqKnlDdOD4p2PF34de/s3HbN3IPVSEL1PAGYNsKXT1FvLKOp7yL250Z3baDHPm7D15jgg+hrqcPQLZfOBxObHRtpVJhD8H9gULPJ6DOu6+eidahhutPWsw9IFzhpjfbI7wzrs/RHJG4xD6Bol0GLi57OEBQmWmCp9vVYO8jjAJaK3/4/okzISWOihorN0bMcfwLh9Kx4Kah9QAwYOSZPSLpSwgfvS+bVzDCjlcKqmciPkkE++kX42RUbdCVXJVP3Vvr1T62CAn9e0dX9JBCgvrkmqA/Uw0ZQ84WSzyOTUjwJ0khMEE2Rm3+e4CXYQng2vJmXSIZBQH3kGpNDUP7BQxylHPGhYwX3A0WNexuYWrmmFkHBcRehCrlXMrGn5biedR4nnD39F4Li4pmUlHQcM1bH08HBBgxty8L5m/R3dS8WZ6x8XPE1CKPXrp0awvRk9X1VhqeR3dvlyU+5NZ5JOmqfG/3qGbcfKw2irNFTa68J+3dIfYQLymcNgFyhw3sJZezQHKP7wz09wO/oT/TzuDZOk9gxgtmMaVKyuL3BR+orgywK5Ij27nWBerAIPKtjK5PdDQ/36mKpwN9G+r/sYL3aAilI98SVc9JVloepZgdFq26+Yw+hM6Sr/s8a+D38LVVZ+nBabVbMTQkWFRThMi14+79HVc2WZ6ukcV+bAp+KHT2Jc8WMxhdZpnX9Wb9vmY5pmu3Dgcf0f7paoPn6MIH6Puz97c7LKypBispKQYFnGQaBeDcvevqqNFkMiTwB6qP2re0G4N0soHQCLQJYbz3Qv9dTJrfug9bat9o+8w14qeJE6wVqyhgWU6HThZYfJHQBlXZxwNjGFvJvk6/beKcuHn7iJbM72A3tb6Ln0OAmgyDsOJn0XiiYQ9SU/UHTFOsngt8MO1CwF6HAqeBerzWbhi15cBClerRh/+ErlypOqJX4/ZDGXe48MBCVKFm8z++LNLwoqAbUNj06XylJnJKfTbPcPvd/yoq/uoSkHnnWeaa+58DcU7H6Q3ttFcvb4KJwUoV/NvxblrJN9l8doTw7jgi8r1glyMB4VSgx1oxONiuQ1QduLvFWtjSyH1idzuSpMxyEhAIofBlvIw/ojv6ApJ2RC6DGfjGgAOUH4o8LT8a937eG48PtxCLyNSWAqP0HDTGCo8/czsqaoF8I5Qz4JBVQeOSSfz19DhtHu4jEyNRZwyLbF8BFQRK2aubkUnBtqGNFVjKPaIiMoIHgB5bV5tTl50PQmbLFlF4vLJH71eMIYKP1q45UeziwJiANnzdN0fF7FfZIKCC3+VN0A00lCjJNZIxahobdARtKEWWBfL1eDNZnWdfF3ssVinvpj8tuzFVesylkwktVDyku2vslPbokxIfDE7xhB1XGXERrxG/znlIfCXyo3pmVHKBVuCbyb3MsgfpKGp5q6mwUwHBthis5NOwkC5n+Jfhve7w+dKXK38QM8jqgGEsc7Sk+SZhXYq7Vsp+QdCYfEqBbmt5EC7nZQFJ03W6E5fiH7K4Njgpu7JsUXM2QH+661MLnawq8zvlLuL/atYCXy2cSdFxgj5mU+LPowKoiVcl2xim0+nSGpO50hnIJu/sATWizRQVnMjG8Uz5ewlabNgr9SH1WLCNBnMcXP2dSDrLGpeona0fNnm4mSUTWtRenPZUK8m7P1c3arzT9+ZNeZRFokcOV1FhQaLw/iWH1qJk55RGKqmRqO6P+gBrFVQS/pvuDbVL2cs01/uddIEWNnnnkz/oaXL5u+JjsqI0KWE+LjHyahgJlNNGDcEd0RWcam7JVkisgOWt2bG/RMxlWh8AdQkfKmlmTOEV6uuJu8iJaLbDP072PFU7jPHDB28ei7NtHoam144T9B7WU4ZsX1o7actUwhzZsx5qntkRwPwi1fm3SuLtmR9wiJj+x++navsrw0W8RQ6gQ3HnZr53b78oekKIJdSue0305LTbKOmUMFCNkTtO5nnYRusFWRuf7y8+BWigN0AC7PnhAUmS7wJLalak+G6s2zL3jRjlIl8adpq19kjrOF8Q9elgKvhPrEe5y8To0C96g1a6Uk+hXXWiy3hdCbUK0vEFNMKgzKiSlvLCJ+zWrQ8QRsuOJpPx/9pDobBGVfvaOFhk1baQ9UVBfkFJtOu3h407HCiChSo8nTP3vh5HoCsV8JvKRA6OUUczshlT8Puo3YxYrzqMY2Kg0UY6QBkQTgzC2e72jhPtStuWqdBGo9nkUKkmIrOE+F/UbHWp2kRHCU0f64vK4w61z5idp1Bb2slVpFfxv8stdsEFu21rPKYAzpRgs85LprzT3I0gVsS8AxJtfhWY7QmmlUW2feq2TDIy+4xGSjJoS71Od20tEiz0uPvATKZ8/bj0ZZeNd28Ryag+nlT4w75EK7yhld3Ns9o7/gj25ZpCxs9GrwDNDtFiC9ypEzpO46eOkzUfbsRWoBCZlI4AheeVY/rzViIkKOYE9SFLg2dwLSaXExwK+s3vRUGFtysM4ld3Q5ynlOK2oVYYE7qjkDoXk9SpM8xTCDpbgnzdwzLBvmKCz6RHgDqyUcMltMsv1UEu7WqXcPUbIqVYmJe7V/58NvIfR13rqBPvSkmcETmvWBDIgl/hYuu3hGiblQcC0bMmLeOZzHss9Ih2rtQEG5Z/gNTmkUUpKPFPNiIaE0v33iQKqTRcjGg+a7DrBjk7XrjvkcErBeovFR7DzYu0zh+eOD7/U+rdVgmLJOGUao/MsX7aBWU1H8pme1mMH99JD4Ah0GHxyGidgZgPc/sb8lMgv/GjM5WrRa77Hs0mOJlE7tZz7SY7mm1OPG3SyxMYGz7j2cGaDxWV6NAiziDxUaCV4DiqB2lhD69cfid7VBVRN7YC/BnvgHaxy3slG1Hl3UPRi4zLJa8Uko/CJBoi/8QIcXLoIVQGnE5ID6CZl++vtaSuOw+jAi55oNvq2TjnZDl2BQurPr2UK+hmUg+FxyVdX+3TW9r8zH7VL6up/16OwiZ35VsbhZjfdCD3PC79X2VeusMA+XdOU/7fTBO10DYE7HODe41UnDv5+pydTxemYj6GXbrBTHQxyDDL/rGd1Gc3w2dhVn8Bla+oBf05qgKFjlxlYQZ3hMlo+mxKDY1K2zjVUuvybCkEgId8ziLC3cIMirzUJPDSKTjoEvRtBJaaMVG0IL68p+pgn+k5jI0gGwMtvRwCVoAAwYvtFYrh//3iqyFRt3GkiwnenitV0mDQMPP160gDYAOUMnRjXtc2LHcNwi5qIkTNvCbI7sf5xd5KWLN+cj0T+B5810axbide7sIq+sIHODI3YU/SDnoPNzJwULmvsJDwOU9khX1PV6flg5Z7k4C8+uJjuSXha7v1XA6e4x2kTnLzGvEKfubTAMG9ME9PJJHEPGlMUJtzopVE3pmuX4LJwBOHKyF7I7U/Gr77tfVOBNVfqG8+OXBraXDaZmyhY8mjNbnxKkL9VwyUVeZYX17qLNizam3PUwOAzl4mKyzHKfZXSQVMPdIrBa1rP6V+pBkmRPHaZRmV0ufsM5T0wJoaV00+ckVzQtweqNCWowkaXvabPI0urCHWhuRWkMGkHtiP13rRuZmFXzj7b2juM2rU/3TsdMiKGhc2sSc7ThV2v8UtSNU8E/6T5GHXdJ7zjRrEDBVUMA0BttxF1KYoBcBK6C1bdfMlSGwk6BoabjjqbB1Bdj9uV5L+PtAOidxbmP0nQSsUeuny9InWUF16orLgniQo8fEwcuEGxBT5QBYy13rAMm+/s3YgHDbt3v6U8OJchLhui1xw8qbBdBWwAkE6Jx2m129s8gwjxJlOXPQ9UnLC4RMy2vPrJ3q1WINdGg0/sHEJTzYX/wl4BCgsDBVwLIH7H7ZqswK+6wsuF3djAXgXYUQRu3BQRsxvtPbd9zww2wmtTE5/Ue3jmdLr3hTcs7TzcPKH5rHklE4kZcVEeJnds33hq/F+XaNHdIivRIGery6ysZFda2L2kZ0JvwJ/9FmjpzVjiCvPDuw00bQ/zSdyy+tp/xX+i5zcv6zh3ilGvRsUIwN8fFad6DK9FPuFUcwbE6os28gT+/LsPxKUlj/DxksvjXJNyovf+0hR2u9Ed43BqnpDg6WSK278Zwg9vfaIHHI3XB5xYEoAURQD+1kbCuLozzUkQz6G6iyRIaW5YXT+QshKBapbKZwt1OfuKDaFsE16MKyXe+iowz3DyT1jLrceGHpxW9Dd0o9dyWCmx7ug35iJavQrc9SRuU8r+1epwYO6XImjXkY1jIrsO0Go3lY0Dy1h1KzDFOxIAod3Jfp9dB7VWmfr1Tsr95A09AfgAwk9TsU9Bmp3dVdSYfgiWZOlgLFWj4X62gtP0pKyKrxD5HT0meQxc5ikCvy7vzSPzS84X9VqYYxBuJkt2DoV0cSebJo88QvHP7177fV/fLLtpaL8S/vKY5/5cUO2XI/DX8MbxTax4+AaKXrq9GtySxOQfwfyESuRfnHOQ3/NCnGiNkrWL1TFwdSf30AhKEfwpfwMtNF8Z89v8jRuk40suAXXNv0HeJmD+E/Pz4XRsyhWarDj4hD86dgnEo/bgdivQE3bBzxhw1tLge99lD0gJPxX9xmsP5dhbPb1/ERUI1strgKttCRE2AjWhbt5pkYqvWHxLhwefnVks2ZgPfY0VO/drn9BcM8tMpHgNVOINAJHebonjEXJyr5+8fuCc4Lp+SeCHvh33n5c/oErqBXQFtpAp5Cw8dH9ZChx2qwIj4RHhA0ikBav3pWlS18bSYKwPuVy3JOF8w4fXoANZGbQvVgO/Xp6cKl2fK/gW0lIIG5QTon8TYHhkKshuZFv2LyEBowk3aJZnTasqbgf/RrpTwFmgv0PBEZrfDPNvp9FIv814GthWnUya0mXVQ0I+39DOyZyi8KNnXM7BUjNbQwyAZqw+oJ9mha5yoz/03+E8bMvkJyrUcbRqqgqbmEMxZLHVxCZinLCjn/CyCK4QgwDriy9DvjvTftp/cyP1Klv3UpjA1kD8bfO0rkHpGv+oi9Cs4fHpUkkKYr7mGHjNTQMUaDeNtlF1rxbPyRUg46asrtD6JpscpmtZAvN7EgXHjCU9T0LThxNH3auDMYZGc5xHPk3/f+rgeNzzB5vqOL05lotaRAtN5q+chcgjwNbO8ejdxM1vNYgYTLCv8UV6Rly7o8HHdnL5yhrC+OolqKq9kTnJkFSqo7lBzLWefrjEXhI8Q7QQueIIY8zJqBYHEVQk/c+fxI15Zifno09qBlZSF6ScsWhGSCb+bur8unCzc70yru8XH27b7bsJ+oQKLjueHy7Im5TMv+d9wOqX0zAjf3Kzhd29ogyGb9fSpTVxk/NM0ruDaWSAFjWgcEt3o0h5DsuJiTrR150tgejz+iU3b1BO8DfRT7CDZtfXdgn2MS/NhLj3/Q9P91aSUyAAAA=="
g = base64.b64decode(_g)[1:]
for i in range(base64.b64decode(_g)[0]):
    g = gzip.decompress(g)
g=list(g)
def gr(x,y):
    if(x>=0 and y>=0 and x<112 and y<1788):
        return g[y*112 + x];
    return 0;
def gw(x,y,v):
    if(x>=0 and y>=0 and x<112 and y<1788):
        g[y*112 + x]=v;
def rd():
    return bool(random.getrandbits(1))
def td(a,b):
    return bool(random.getrandbits(1))
def td(a,b):
    return ((0)if(b==0)else(a//b))
def tm(a,b):
    return ((0)if(b==0)else(a%b))
s=[]
def sp():
    global s
    if (len(s) == 0):
        return 0
    return s.pop()
def sa(v):
    global s
    s.append(v)
def sr():
    global s
    if (len(s) == 0):
        return 0
    return s[-1]
def _0():
    return (6)if(sp()!=0)else(10)
def _1():
    return (12)if(sp()!=0)else(13)
def _2():
    return (5)if((1)if((gr(3,0))>(td(((gr(5,0))+(1))*(((gr(5,0))+(1))+(1)),2)))else(0))else(6)
def _3():
    return (9)if((0)if(((gr(gr(7,0),gr(6,0)))-(32))!=0)else(1))else(8)
def _4():
    gw(0,0,1787)
    gw(1,0,80)
    gw(2,0,5)
    gw(3,0,400)
    gw(5,0,0)
    gw(6,0,2)
    return 5
def _5():
    sa((gr(5,0))+(1))
    gw(5,0,(gr(5,0))+(1))
    sa(sr())
    sa(1)
    sa(sp()+sp());
    sa(sp()*sp());
    sa(2)
    v0=sp()
    sa(td(sp(),v0))
    sa(48)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr())
    sa(gr(1,0))
    v0=sp()
    sa(tm(sp(),v0))
    sa(32)
    sa(sp()+sp());
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(gr(1,0))
    v0=sp()
    sa(td(sp(),v0))
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    return 2
def _6():
    gw(7,0,0)
    sa(0)
    return 7
def _7():
    sa(gr(gr(7,0),gr(6,0)))
    return 3
def _8():
    gw(7,0,(gr(7,0))+(1))
    sa(64)
    v0=sp()
    sa(sp()-v0)
    sa(sp()+sp());
    return 7
def _9():
    sp()
    gw(27,gr(6,0),sp())
    sa(gr(6,0))
    gw(6,0,(gr(6,0))+(1))
    sa(gr(0,0))
    v0=sp()
    sa(sp()-v0)
    return 0
def _10():
    gw(6,0,2)
    sa((0)+((0)if(((gr((tm(gr(27,gr(6,0)),gr(1,0)))+(32),td(gr(27,gr(6,0)),gr(1,0))))-(48))!=0)else(1)))
    return 11
def _11():
    sa(gr(6,0))
    gw(6,0,(gr(6,0))+(1))
    sa(gr(0,0))
    v0=sp()
    sa(sp()-v0)
    return 1
def _12():
    sa((0)if(((gr((tm(gr(27,gr(6,0)),gr(1,0)))+(32),td(gr(27,gr(6,0)),gr(1,0))))-(48))!=0)else(1))
    sa(sp()+sp());
    return 11
def _13():
    print(sp(),end="",flush=True)
    return 14
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13]
c=4
while c<14:
    c=m[c]()