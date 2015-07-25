#!/usr/bin/env python3
# compiled with BefunCompile v1.0.7 (c) 2015
import gzip, base64
_g = ("Ah+LCAAAAAAABADNe3dYU126PSoKiIJ0kCYgIBiqhWIAld4EkdB7ld5LqNKlKE1AikGkKEE6hN6lRoiCFOk9BKSFXvM7wZm5353vzjx35t77PD//YGevvd71rnefs/fJ"
  + "9slhjSYmwP8jJFidUC126HbhWmxyfYTgujlSmxurGHQDvDkuTU6cb6p/q/l5m0zb0KfA+pU3hwZTseXDPbFdBqnxqAvS7iTW619fMscLFDCW4E4G0ptwR2o4ZOBREw4V"
  + "eDSFy1TDbeGOjHGrTf6HA2NSOCfcztRpsZqU/ykhwefVPYLmU9ipADXBQwEoGcFRIpqgROr/vw/WhyfrOPOjQFzrwN6F5RE90URwhIE9X4YiTJofQdt3E8VGp0+K9k6a"
  + "yIU1Sm2kXQ1z63LrQoa3is2LzVtKzzBhmbBlWXH6TuFIz5GQwtDxebGMFq3HjlimPpPbbCKAfklSXN8n4pTVEsF0YkyXm2icaqj7vBhTF9djcSwTmQUVWxiGgX/AlA9x"
  + "TcNbvK/h5oagPjEPmBltROn9li+UGvbaTYAE/JW2dQj2epMVPHFNNGk1pFCCeUrKu5bNmXeMSN9XvDFww116WhNBjth198NNY8Kb8+1Z7W18Ji976qTnhvB1u00zJpMh"
  + "bqKCnHTERxLARI2mGJPbA271R+efEl1IATHay8IusJbZl9BAyfy6ylq05sU22JCXxnR4FYdrSDY6PrTcB5AE2RCHLrdpzuhLY3HoZmXaq8la6TMDA269+i1QEANIFXZB"
  + "9k+NzQGTU+0vc5HQYxA9SBF2AfKnxjL9Cm40QCTcD0QHAlyo/qkxX5F5g9kARV9EjohfXRADI81ahBFPpKFkqDKdkpjCAXVYWzmIFswLuaxleUhL0yIJogY6h91u3q/D"
  + "guVzlYBrjCpV3/ikieFGzYjRXmZJFD6wEAe3CbeYa+TBwBHWOlzeKj0/EtEbV5CEsYqpPlgmmGmqSSjyfU+m58Ht0AUdLvpHMO7ia8nmqSaEUFj9Y53XlsEU81DsZVOx"
  + "ZJIPP0J1sKEPis28M2SDb2GPo7d4wzt1b75kRzWJ/j24RJE8c9C/Wh8185SWxKdrK6WvgJ7FMv59BDgQ8yewPY4JleSMhlyJLZP5ZiYTyq1cBajI67I/F2JvTcwdg9K0"
  + "ZYMoKugpZrp/SyYT68W83LDAeBq1b9xSJqyU++LVH/qgQM/7DWewXvbsA9PWdxA+cA/lo8Knm+8EZ/rgtCyWke+HPu0/eetsDSEF0qiba7pzP6kuh4d16rB/EhJuTOQa"
  + "1x1sNQdR/KBnmFKkWvtsOyOUTGwbE7OeQ+KlVblBr0x4L3zRs+9Nwer5b18oH72qvoa70e2aZ+BA94ILIH4J2ydSTL6zYFtHcLdURp2D/4uUQlkGj/bYxfeRnMHXXdhO"
  + "2XsBtirRbzbRgZcNni3+my3Z1aRcDrAHzp2xNx+dGqYtqNSkkRGogijeRJFvkieArHsGPc99sop8r+kXFxhnIfasCEH68J4yYe5syHHITWSqa6UhAVyX/RYN6zzrTd0z"
  + "o+q9lI8i9681AU4Uh/tJ3r+9GEy5yRYQbwYE51I9FCIl5JyVPmZvB4wpc78woyVW+hKxLxsFZE5+QtAOuvbmJflmNF76HvOZtBDXF+Mc3b6cAgzBmbTQWVVchkBVtsnE"
  + "SjEkm3RAVRigKs1yGXUzlZfGgJEcOwyh+pfzjyJdTE//moodSBVDukXHA8yBnvg56tKH6mYGb5sUSjN48D5fAj7nWo/xTmoBJ7KAE3qqeTwb81e2Spxxjs5/aAs9wleV"
  + "iK+KgpTQqyN0XzUYCB5yJKgCXRtnoJoXIcEH150bL3vobK0SN3UTH7x6yRl5vuUdEJxoAgRXMjbz4YMJD4Bg1drkvwTTLdKRJItg9Gp/Bxu8Nb6pMwlk/h3sYhoQbwIF"
  + "Mv8OzrM+kI+Q1Jj50RauTVKje6OaimJiEHPvHiavw85O/oUyLfGajIyXh4+qam3+5ugoxXTCxeAHFN8N3xk9S3S0rUd4ElZbBE0/kXHX5h6e+z7qilmTliZ7cQcQepbu"
  + "w/ZdlBPzQWDC/3nXOWcuIJvtM4Gb1z/eNNzOrSO/KkbQhw91WA6TmXuTE93ovpfFRtQcH4DrPt/yavQHaWR7Hcqdc/rrYziZ0+Hj6VdA4qcY7SQ9r0wG2vzvYZrMk9th"
  + "zYyA6of+Yt7KNck7II1s0nzxegxpkAjedq4xxHbC30onR45Ow8N7gO68EzA7kUpNcEvfnZ9FhFcKLH5wwhuJ99MA4dgvkwUosuh+3bBuN/o2YJrkzdYHrSNkMZ9b58Vi"
  + "TIOm+zhK95bL2z64a5limTpKgCuqN1rJdL8+2IYu35Fmow+4pjM8w24jG5fzDHNqIc0PgHs1/KMByrTt9lvP+GWtc+v4mwLmKhFxtdhkVBauf7G+HBDx7tlhulsfHEvG"
  + "6JoK1zpnDGDs7OcimP89zJlb+GIbeZpWizzR/Ql43fVpDvw8fDRZejTAu7/UnKfvoX3B7wtQ3RL1FYnnehdZmUfcC9ZsX8TqANf9XXAWkWrBdPaFdMdBw6sbwG3JyU4l"
  + "9JVDROD0NFn53qn4C3CE8Pd8+tn4dLrAQGTu9UDmhzDp1CXNK5tdvdFNTQsar5rIbqCyVNx5w73nF9unplzzO4yJ4tDqXOI0deCArdn14gb1TgHCj3jzd8l8Jf5NSB/k"
  + "gYGHKOGqcx9PkyoTcrZylA5ppBSJf9qO1eclbCyRUWcHU9rx/TdIynxQgGR7Wv1RTzQDWMNZLjrm3crazJpbnRKDrTPAFSN+1XZd2ah2+X2a1Fo+LZl10HuZ50xDOth+"
  + "CNHgsYtapbMoME21zwqHXpKSNxhssg778ah/BXYa2Htb4dlWaQHt4857xpepgd3lA/entJjqjW9IGpxLb8r5dmCfXCKBc3Hwg7dd2wMNtnIfCikTevmcXzpZr50TXu5n"
  + "g5OBTtpewmdMkonXtgm/HU15dFr+yJXWZNY5jKCAtLWAKMYxJO/3mlZeIz8pR3wSL9km54CHh+iyVw9QPVwPHGZOeZpC9tTDBMMqp3mVqFzGmZv9RZo5doU8gnUEfvgt"
  + "QQqeT7YfxAms5nPUlIkzRAi4ZMV8rC38QoBJJLCgCcK+WOwHFcLJ+Q6y05ZfsOqwA1vDQzYhhgCTgmVp5dNPeeLTRIA1mVA1N5kA3EzJBV9NVh2s/EIvoeSZwP5d2Xl5"
  + "VrIHJfI7QZyBmpMq0xd+05/JBGz/N+lFeDrYyP/RXlADnIy/YcKfI4j0N+wGbjwMXrvgC2E28Kk7kjtPB6IwiCTOXPT227k4QbQLF6/e9tx7RcgP+KakkOzd3F8mrSX/"
  + "BfFwxqyuMZIYlMg4c7J717KXLVDK4kuv3rZauHoRb0VJZuNKZPfaBX0Iq4FPOTb8POtvbvgXiz38fPA36EKlg8jPdMHSZmVHzVqDRCmTn+uzmolAFPWUNOB35/QCI9mI"
  + "JpkPsdP96YMImv1wzmDtD8Ef78isCAjNN9dJG7MA0qOI81MlMhtKmhvu4c9POMOZvL2WkCHKTlpjWsCXQmKjyMuwvmuFTV/iLqyT+UOdMb22Y5f92ihbbj9tGWD4sJNC"
  + "7zo9kSWA9+OgD3x9ZN9XcN9wD30+IRvO5O4xvTCTDdBNI6c5vgP0nAU6Btdvg0EpEbGOtzfCOINjZYjUrOOSjS26HmkTGbFI1hY20yUTS1Iyg9890guIZyMyZPaG7i8h"
  + "zhv/RfiSzQFnK3ntgw3sRjzfxUbTeEB4ZoAhbyGFWGpprRnZJo+g3g+XBYQj1KzfJhuzH7+vuyBAzvpTY5qRlgQQlnxnqhcQuRGyRlYP9rNQBhzf3J/cmIbiPlDEj2Ib"
  + "TAeNAkQPBfGVN4qA3SebnmvWDwU46VSmsL6WvIKfwfWr5O/2BK7TFFdOMWqtLkRkk19oBOrzbZNGn0TLtdut7oVDfA9mltpe4CdjsutL+gfxcuA8FCdt5zhodHtDCkho"
  + "5HCd/2MeAZRM8Z929CDURUwqA06+R+36FVd3LeOn7VYVG3UEVZtWV+mcvt8fSZENLq7kPjBruXuCqDKulx0zMaYlaRyCzUdfHNgemwzYpHUI8dcFhHwTUMp9Qu0yzD/c"
  + "E2FtQVN4cUsVNUWk2L+DeWszfF9FfILv1KXzU2rxZSDZW+qG5gsQspDCqQn3+BLbGQNakslKLuNKPrjtyVpedCiEFF2msFF07wDu8BSy4iViePOznijgXqQwn852ZbmW"
  + "X/Czq2gE0L9DuT40NOhhaKKz4EwWTehkdXOysLBgpba5pGeGCRD9qlCvr6897BFkmtQmBqKsT433hiDgFSvfTJNadUFU9Qzxrob/Qv9HqKo9mdZbPY+lBZZ8sj7z+Pdc"
  + "z82wxS0/4NICewoezizRhPceUSUGXs3TYvapkYeHbOnc/ESS9vbYTrBy+RtSQoM5o5P9kdO3epyhjDBt+lDQmrJKIWGfZep7EftJXNE9mnSVlYd7nHla59FlKt8Y7wMb"
  + "YlqUap7H+yPKZ7eD3HS5lq6m7zXZqbZzDYh/84/MT2quAVFZMzLfLVT8eXO2VWr8dDkzusliuXBGJTmy/BVZ2tv3/NQuM6yOgTuodmPhnSFnLuSXn3JEqirqdFHVG+RV"
  + "TYfoWYFUHzvRRMtZ++wQLq5PpLIG+xFjxidumykqDfcyuoVdEBigpPG9cIPGbkmRsEJdrr77Es9nKX1T3oyj80ruAYJ5RKoGZusJCUfj1AirVNGx7feRyr8MNVwz01uH"
  + "AH/67BaT5DFft9AFh7W1C/wXD3S4+hAyXfWs9AwTKO0dDw+k4WVsqUqGQ2QcVEpQuDazeHllObmOet4c0KJk2wowsXCXMh4cHuTz4unqFHYpWpDm4u/KhDumRj8MoI1y"
  + "42O963LuVNMDaUCILVfPsDt4H0m68RGuv8gelxk2a4AE3L2QgkwI0wUdg6itR+9bTArQ06yaFwTMq4smhs2qjIV/PbqYbeZnPxjLdNm6TD3DZiwO2mSiGRNbeBgvPaNC"
  + "G3XHgVF4nS4marMUIuV6K6P7sUueOxsV3a+nzG89r210/O5Szcf/97oZF6QX41VS0IJJYbOiROEx4AjAV6eYoMW82Lx1lmhfEBsHik2KtN2F8KvIZAHZejg4Ih8gUAhO"
  + "xaHjQoCY84uMWCbXEnUm+WY/aZg0GW3UHPFbMQsxFct80ddxqdKwNs1kAEoVm//PUPa4ZYz/y+xBwaTc2VtYP5bC8HwQjXw8euv5PTwvCpwpX2DKq9z+lPArUxWuQbGO"
  + "LQ0gnrcig5IN6PK+ZjdZjEMLvvsjxGawGH8G0bdasvwTKO9WpCtfhHdylDlxCs+8GLhNw+XKjHAY/rR8NhwHnJaV24VCkdRlwGm5VDT8RepjWNsdEG3nNcFnXW7e4e2z"
  + "9OetLgNH7xIdpkfVKhyoGQbaaA7iFBu8mJkL4YzwK7wY6PUNg7x4QCy6nSIUeRcvViMa/CJVDi9GJ39NcAAvtjBLfN7qOl7MIIfbIC8Bf1SX9Wm15P2HEJdBXq1DVXKb"
  + "YHL0j1CkJnCkN69RUK1W4UTNiP3XECFSE8hu3vJXiDbmr6x/GaoAoKrVIVf6nuD4ZOdUJfx/UNDbkKTkA7Uj/xOUnG8BQAl/gxj+yvoDxEOSgqlggll2KyhWq3xc2AAp"
  + "yym1WorzRVjrCmtQ8g/YnNETDFKX7yN3mMPLLXJuauPnAwzwXM/m44+QuKuluC4APc/h0M9LBKBoOfEyS3HonyD4GGjY7W3rh/jX9ngj10HXMV3JgLfPLX+A8ruSML+h"
  + "KIPUJ/8YeoOxAKCyv0GMf2X9Z8jrGW/yQgkZqTxv2cI7cESbjqhGPN/6vBhTR2t8lD2UGzUjSPta0wL5o2xB7HMbHotHO9/C02VhbVkgpvwuWihZRJlzjqsnQkVAH9Ym"
  + "DmAZ7/iwTGRWMwoLv/B0QYBubR0NjgjRFdUQe6Cfl8yHNOVLfq3Z10cHJSMqdweCG7vcRN/mciSVbwG6LSBmQENg0HKvArgr9X738IoYQNEPr6gMKKLPFMU1xET04QVr"
  + "DomgiEodMNAzBtz3zcb31Bywo2acaWM1+3qBNBHl3jmujh0qvVtIEGrKTiehnSPJ7Q4gPwNiyc9IFwLkrTcVFsZjAHnRaHle9CJSGDppSPLtyy4gBWw3M84IQOoqA17K"
  + "H5DqAhxnrHIk3ZHOq12evN+9xV48mq16xfSzwsLXuHi0XQJaxfKfftblQknDf04V7D5nkGbg1hDbGvxcVFulao2o0YGm2TEExVDlZxzYamlPjOXdGTP4DO6tjHnYEanZ"
  + "53evACh3INWBXwu2qCd3Y06G17oxbRCyV6Eoasir7FJoTmCOh5LPoFsA5PQvQhCavfAo9cNvEOXGU7VVc3oOPPoGQC9FPfwfohUK9P6fEJyjXdc6IoBSOAt412zibxyq"
  + "OyhXxLPFkAMVK2lBxgfYH21njSY/55CmZwUmJukzvPqjbPCSdCXfd7lwQckc18nbuhAXpzjiD6zbFTK3SSzdFRbq6crgs5PgtRO/xxJ835UeMzBriK2HAZEisb5Smepq"
  + "yhUJ6nJATl82IGfv3CSK+8cAZeHNN9/ZkraMOuFRvls6BP6r8PTRbr8zGnMBL+3D+KLa/HdfrfHyw6Vws3PUmH9KmJ0koHi4XvShHs6sp0RvLs2LbojBT2bEBtSLBo3N"
  + "sKZnBExZ4k2BQ1F1BaIpaHDbSFwPVMAc0t4ww+Y3adheA0YzdITj9aMLVq++/0QwNgXhho9l5YYK3QcKX9ExcHAikL04clok/nSCjI8zpvSsgFlb3wu3eJt3vQYjlz2f"
  + "85jGXM3P2BOn1R5jfPj0HKKp4IlmlbQyibn9mdHq0ckhmYsjk0W1335c/qOEPhWD2VHt8uNntyveCP7NhYOqxcvVFTipauE3jdazEjxARYiqe/FsiOIC/ruVj38Lf04p"
  + "hY/Cpl9eKfE39MgqoLGuSjrT8GEogK+SZFGwITIL+N0rZ38hKDuAonWBoisl2O6yf9l1Gwwr0sqY0DoTXwHmB8EdKhc6EgD4G4wqHzubSmtgKgd3Q7+9vDaGgtDV6rl4"
  + "6v8h67XrFGa+NcsPvRj7HG5n4YvfEdaCjFHJZAfbs2ozLzm21ThwvgHqLDfqgNv6Bj/XjFudg1+YcBCtKgwVBiZ2CKkDcVC79upymb+Bx/u6q2hEkvpfzPOu2rwCpSx8"
  + "Ri0BpouzwZmPYeVE2XhHr7F+l6F9LDFkQDrxni3gse0rKA5oARfJxunau3S0dPnxIBvFVHcQnkIjjvUThfZJ/vPPhtBJny6GQn+39AUKPtHiwivmwM31Gbhm/TBEzJXy"
  + "yqQvNWBrZvwd6MMcfXvVBtklqK+vmIF0GzL9R0QoM74GPHHYMCYCEqilz9AD1CJWbA7JlXBggD1XrkViS5ZRtrel8asG7fEZXvGRr43KQdFLl0XrRNfB8hZQLrr+NSRp"
  + "t8LS+wMfhh/ZBpcqKLyCX3gZ+JSTd6+nWQEym2cybQzAskWHgYoqROLDuUYT1srAnw/LR3uc8YseygbYVs3JikTk1IHIC04/I4QzNtmS3Iy6ZpV8qWye/0He2g+Qpyur"
  + "7qHQDXiiH6EF/Elt3QecC+SAWYGrIDCHtxWH9SOG9jXid4+txz1bbPNiR8LAHtFHqqth6cWuqliZOy5TA7I2lXsJJOdUhv96ksvTjXiTDqw+0FfieGAeLBSTJvLvcv5M"
  + "dqUCVmkYAxvgPgmUX/YgKe/mmIbjrAGsXBDYwtD1CZwQT+5+XagkH9KYmdaHAC30GEh0mwfV1u22axUKuNXWgEUkon/1nunmgMm5UT/TKdiB6rrzQCnoYpVebCzZFakX"
  + "W/QcGt2s4PV56C1o32kMRf48OcwLC34Dtg7seKmJJUI9gLIowcqlgA35IAStqhg20X0TaSnmK6SUkyDlN9m1pY7NYIqhBMIyRfBh3ETZALMN/QpMzonqbrkVr3S6Ab0D"
  + "Rgo03YQoW4pB6bk1upklgXT00CcswFPENQKfQQ6WGOHCnjQ+s/UEFhGPnjfNUOD02q8fu4OakvKmyxoIqMLQeeco9QH4QgzdVlFtXOhltdo98sn2pYoph8OLLPkJboCy"
  + "2Fx7fQH/zazWxLWTEC8h8VWv9IAgefg8E/5x5S20DidV/LSR44ubNox5cjSRZzwdzyuGz3vH6Gvd8uP+/HuYNY0yZQcKad4rD0DH1/qscoB02mfpbFXrClAeBXxmCmGm"
  + "EWGsrT9jqPMzNm0nIXQJ6oU2Xjs1jpWyV/IFf5VsSIumx+MlewFJSvi91SLJ4ULESzaacGbaAGLrOxo5CbjB+gIQKEtpYO0ks/hU0kB//TLvyim2/0Ib+TlzWd4D4766"
  + "nlYN+N3NSdwBP6d05U7R+7I1AQEJweNrglpA+AI+PFeJav0kc11DWPPfCs9S0lhfc8ojLvyc+0yViEzsZTnDbY1unOskhDZZg1PIZ0/kWajWUH9+3oUIpi8/Y2jy5wPF"
  + "1nlJlfMT6BuO0nke37bDaA4ESZPN2ndEaWKbMrySwnI1FWMmT3qps5Iq3eGYZjYil/t/sCOoStevD1FOSSNjcr1Gzwfk8sHn0gxjq42bhOvV/nCfjgtpfg7cL8NbRWUl"
  + "ObxXvodtaw325+IdEMpFA0lgQBJOiOlL/pwqeDL/PWbR+RuCejkJRzv1Bbx3cy9LuwsV0lR65teGSZMFi3REa7o2vfeChHFBTF/w51V+GOKHVDl3Pdro8I5XWqPbLoJ/"
  + "A3J8a6/Q+jGau0xLJkY8SS+g0X0SPAmhSdMMO1f7dihKr05zopWNqIVxTpb3WeYKZg1+me+ES7ST23zl4vJp4DMq6FwC4O6SUwxd/nyA7Dp+mPdc8XYSvfM5aF/Wv4w+"
  + "KoZfVitI/5YxNtmP9PMuwFQFVkAykC8Bw9rbcPjGl1qSrzWrfA1fI6rSAo7k9dtrYujxYviwz+nN/2aYX1GhF93RYvjAbZ0iw4y2t0BYCj7sRy2JMtTIq44tomU4hgEI"
  + "UMQHFKaXvEF7VDG60vv1/kOqv+o67+Vi8Yqk703tBUiayOqHO4XhzJfX/34M4joZ9T8fw8z7qRbDGTRcdARfHUsUUd5d3KUQYfC85df7Kf5JH90OPI2NJiJsoGtqjlfW"
  + "3JHVJdE0onU45joQ9vR3mCg+TONfC9NyGaGLfVJbcJdZijCW6fLUHcecxC1IA9xKp93UGCy+WkTpcXwN7HrLD1UNqGkDaqY0Ef6bSxV1Sj82pTe6sjYk5uTExYwHC2zD"
  + "IUy77dkDa7xPO8lbOCJa92IYgXIhf0miplgvb7az/I0psfP+//KAH2SdN1XDZS/lyYGD1em+19PGgx+lzBzyvGLGWtBJD4WlcyLWnGniCPN5BU40khdVR0YiMb34WeZZ"
  + "p2cMExCuuwAdZssiGs9Ier488jqe452fgJ0DDNVonBqfLyKhYSm2IuSZk7jukYQunOJDib0sBRjFBWCnE0do36MYZsy8r+ECdMUL6UZm9kuBe3hFT6PdaFBuyrUBZIwT"
  + "ucFpLi9eY6QNNTr0x2a0MTzo796p7dnqX09EM/WNxD8pGobAUgIywWjnjtfurg1FlVDJLUdU4sJG2HeOdwYCn8FNwLGLNBuvoQMNAE5zdHKxAK8EexwFjhCIYcHMQy2V"
  + "b4987PkgCjo+yeu0GeAzvT4nLw41Gu2/vJtfdouSNLAJEz/qrvy2Yz/+CSwFURHsDwdFfWmdcvLJuT9BmScUkJOIzuUrNMnkjWYv3dhLZ8lXrQq1iWEFpG1+SyvgpeVt"
  + "/0M6bWz9qc3Tm7SnAQOBi3n6rXc7Yt2x9RX3qozL+z8Qx2x7s2XzE1T9lrBzbLLKHYSOr2w+ljMkcGSQ6u/e6h8aD+hVKtiqHp4Li6klGBcGPMzlFjacCA/SchtXdxZc"
  + "h56rtiRU5O600/c9soQXRk2rx2rfw553RhInPHk9jNjdRWrq07RksRTbzl+cTqa4+Y6p2GF1NSUfwRssLWE02EXazMehoOTbVF1YFfC5f3mJebF0WY7pCiSGjWf1ZBkx"
  + "eViqVGDu9bYTzugiqCkUnlOxVzDms9LJW/h6wpSlwPFLi3o7fUL/ZLHjSiFrQYW4ZwT0cy0FkTSNuYLSUWOthEjA51F41zszHwgF0WO6P4Lz6f8W2FD7VMT/8zx8O91M"
  + "T5ZiNcRRLv7Nri802/FQp7sdI9JbEcU+SjQRw86zuoeVm9guTYgecEqzoZGtIK9lkNUYXV94VYsx56T7OHV3gDfqOav7naicimEko3+dPPJ0sTmtbQqHEJWTl1/duHDj"
  + "jcvN3AajqaUxCb1dEaIhptPTKghUQtgxgpUgK4aDZ3XnUG5q7XtZk1jJ4sZeU2HPSrzLg2MCYksmRZviYZFDz9jkk96gexFNOAeIUWzM2AzRw1tzCnq+9Y3ZjohHmLBJ"
  + "gSnapXeD5FIErfTS/aNzg8we5VeVBLYDDg6vkX8K2D93rYM+YYileO1TuoO6T9YecjjC++FOG/kLwY64il1vD/kJ+5B+0gbjRskvF+CsAQShwNWp3EU+OJSLTmbO4eqR"
  + "Fhc8JliyIlS0W9X22n5Fy/dAweGNl5fJ/rlvvcQJQ6PFa0uMfHqecaO31teaNy68T6e4WVhpPPFdRK/i143Kp5MTQYBjEQ4FPbum2oYqnvznLWUXBsOg6nR5TOdVY1hs"
  + "Ck9Gdyfzcj5cRJJp0s0/MnzrSnxXyAewYDfmm54QRQt6oG4YR+Rh2sP27ctSPJDPYd1BiVev5NdDj0csP8J4Ih5SZcsD4gi8uO33/pCki1ATujyWS+0xjIB4K14cLqtM"
  + "rkVTTGH41oeeGthzK3dJ8eJwWj4JHUi9nLvpsqn612pAXMAeEIfrVWybQDavfw/Lj3gkNCcHiJdoV9XW2dhYRidL9uwlPYn8mR/RQpONHyn6u5GRf3/EdkWyVHsdNyGr"
  + "jAtogEes2KxsKF+RoAYeuxJbMK+Jz9MfcgObjAbbdio89jnDWS7LxfyAQVF1jlrO3/ubjIuXZ3xGxY8ppckvcsjZourRhiK3q59jpoq1d5wlHJgDIrMigik4Kq0nt4rS"
  + "JwwqFteH4d5pQ0NParo2pMVSNtkr0ZPYxf+9EeupLcrKrGfXtVYg4oOU7zbdBJO+s1fuPCu676wUYtug9FHvw50AsjxhvRxEQM/gpSc26oXaGE1l9w5Ui6Zc9I8htZrR"
  + "Zp6r8B3ed7aRfftib3uex08a8Xh5dWuH/YIsUA8rSuZLBwC7qV5OlXb/hCEWwuYLEWv3T1BbissEdlNazGqSu1eKH6TLCPLEJXOeSnye2/R6tqyPL+fEBKcxTZl20rNx"
  + "7oNQsgPFtx2AtJsTtEA7pf62SeblKZWapYVYqWxp/ZObv3r/D8cSrvlAmrHtJ1ajat9HO0zp6D2v0Qv0+y4yrz+9/piVpsTPpSl191kFwmXkYjgzYUf0Ngza6fsm/Jv8"
  + "RZDxuFPeCXWhA5NnkClR0CZ7g/XkJksu2/bTc0i6vXQbKVk7xghDk5FHJvUK66le9cPZbHfHs+PFVzcMmhiQd4xyqqxvStI+fqZSuFiqtXjYqwMDJCQ4NkuvpZnZ3out"
  + "FB526sDG0GFWGSJjw75RPyuAfk6qCbiTbF2v4DSlM47tr2LJv2V2Cc6fit4zY+yI2Z4/0JsXu2L6VUENVgw8NK/9ARJthUFPrepIp/SEUXbCJwtEVczCroJWTFlHzIFf"
  + "Pekad7pQzmIENHTVx9MIaTmyjhgO96a52J9rrVUsBwz8RO9nz6ewjnt2dbW8dQld8zoWGjPcH+KQalsg0DSYxoaMkTGI0d95fQ2bLGWbHk2beko1Tvaw/aJSo11mCzv5"
  + "XAfFbqBnVc3zeIzUI4ttWmsobCqaj17kdQmuvK5XNloFR8KeXSWK3Do2sm+pdgk9yZxw4NezOFS7xtDQrgsDiiPteMXh7UlygMtTwXgx3Fq848nUshUN5hYz76QAN3W5"
  + "JfwBEAK3RESfnly9ZicUzCQNY30CS0ynmKfHHjtjM8ZjbnTGoYGz9bwVoViUitTIauwU9ojxRrLpsWgUWOotmFtkrvPp/EHLvFgNg9RrdhQ5F6q7d9/lTQL3xBPgwV+H"
  + "p27jqRlgboFsPHVmXgzKIIGncqO6kUsuTNCAEtOmBrZZl47Xc11bId1uWGFPJnkYqwosMaV0ThR7bILNqI9h7qzpdUO5GA1gx68JvYv/G87UGY8mAvxZzou+PjMkwNGZ"
  + "anFIvFLlvOTk+NL7jcucCtYvdEf/FpCt2oULKtl6yPcG4I+LJoJZTU9oe4B8jhnKMPnRj2FtAesO4g+fdLxy695SOKpQhyUmuswZYMH9kvgQi3HRFHBshRrpgpgYg0gf"
  + "J4pjdeAx9AlAL+/evuVb4bS/3uBH1AVkuQ9lsYzd7T5TVoXJ/8z2x1tltE5EP919ngl4nLskLNHKUsh4+kBg6hzAuoHi+PVdHPrEqOPqPDRUQg8/NdVB4NgS+RX8dIl4"
  + "u6VgYIu3jyrwk+ISIoKt75Tkw1c9Pv0KvF6qhvzN4kD5/hoQPpOZ7N5mOapQwlcQ4oWnFybgK5h+h6cXzOMr8ObG03nxFVxt5BrQX/3+bqapwHRGCN9FAV3mM6V/9FmS"
  + "fcDt+mH6dWoWwAUHFsz9FxTllnBm7G+QUQ3SHbUToBQwsDg16Lxxi4OouGvLD+9YzFsWhuYAau1quY0FswJsObKiK/64VPh21fGpl//OUcAWUXhwJ4NYNTtqKw64C+en"
  + "o8AoaeAOjQ8BIsihTxzlyNa6tjXsvLI4UekShiAiYU/nTioj21X+GFKntubLMczjm6EpenWkc61jgiXnzYm8wDO5Q2ut1Rv3r3xuHmmhQXm/8hijSPge/iKXQaJ6lqe4"
  + "1PHBY9fRayV3s4m0wQv3hhzkFZ4wnk+22p6O+ljfUbtK3G0j3dwfw2Kw+Xl4P287d9R5h3HnuCPAfcj0GKA0dIjkCgyGF0x9QovsZpeTzQEqq/caefzz7xucyEk0lbK+"
  + "86CXqp61Kd5UxShXziyLLB+8Oln63Lbfchu2p2eHyFrQCLDYNaeeSYKLTDzDKcLaEmPY6zV28nyXpbrdvBOehmrDJ93VTrihZGrCUfbWo3Z6WHdfbBPCCBNA1Wea9/M1"
  + "2HjIJ/dIVTQi1eoB1k93JWlNZIbJKm21a8uyULt2KtTtrQ3izoJNUfeLfhU6drcDBtHoGoCZwR5wqc+sCIj/+DIzqPytHYIDxTNrPQ1aTCtUUUQmX4ALG76/kruT0W1f"
  + "nsSj5oE8d+8pv2ZHv0+fBeJnz5uPtQsv0m7R8ZrbSFgLj9lb9jybcH2o+oY0qbQCdifVASHMyePbWM3Vf/ErvV5v6lcR/dSE1xLGBowLj7lgWm5cW71aeTnmKLphuZq4"
  + "yI+DGd1+QBLMyFZ75VN+i1mbe9bCU/YLgwNMu/Z7iw+fwUgzrukhf34V1YfugCMkJhp0v9HOPuYOHnK9f6dPy0gCZarm5URbEVb9LfJ9ZUZvTHmSNsptZGAi/aIDG787"
  + "+3M+6ztzgNwWEzZ0z+oR9Dndp9qDzQqqeTFf6I5MBHiuAaqeMcgJdwwArxJC+4yMJL6zobydWKitPSLh6axqDx7BylO01dy77kymE7XrGn5YXuwceBKH/rWwHLnm0+Fb"
  + "Pr3mVhXk9rE6Ifs5s5/p0M+ewTsTO2/2Flsm0FHBH/co0d/F91s/lycVWNeu8Kz3htShaC6qrXP2ZXtshOla39ZGuQ8/A6S9Mm9fhk0qZ8ivTJOW92mtwTCL6Hpu0igp"
  + "7TeSYZNNxZ9qOyE4lqSpgzJZZ7I7KICwsmjdwE0VJeWV/pDm/4SgBPu1/LGBmzzNbf7+q+vUzMcvl/Qdxy/Tt4+XJyVY1x1C17tDF0E1qjmXZImk2A+TGavOywnt2efO"
  + "/ywKmPQVzhJTdqTKf/S9JfZl40JH4YunXyX0eaCIgsw9mMrzvoQxGVt19w2OD041LrdNqN1QnkqwVTh34z3yWiBdkjjE0OpTl76D5v2vFrs/n3QPGO58rbJ67JU8zvXs"
  + "Ixx5hQZa8KonPPWr5BgPtLYAdjCksgRIWixreqRmsTtVPv0pmPjT+gGnmtfgnak0kgld13SVd3D+O5rzhfd5Ga2Ej+w/LmIa/ZZ9hU0VXo9zQWLXxmQhw0cHlQWhnW8D"
  + "Ec+2/Iwl9yRqBG8qR1EWQPZWP8BXTo5HIa3mX6XG8qGNAplHMAP6BE7ZyEH4kefTwZ2AgFXeGaHFzNUf4KkUlL8a/5XuhA9fbAf96z4t+0g1eSZt0G+hPG1h6ylqAWos"
  + "V1AJH+aXKTwHkuE+knVGkJIrD5qBwY0UVIAa1xVU4oft/8XBzI1vOb43leG8L+HuJDaXgzZBF8by/ZHSz9bi1fPhN+D9nDk8hB3lV+w/7vKRq9bIP86FB39SSonLu0aP"
  + "Ei55N1oFvrvAQpIEv/yB1/Bx2mMTMLLZU28SGxeqz6USBcfki37Qb7vN5HNuJDbX5AGfk492raG/ojHPq/+1scJ1H21REOMtzm5tQ5etlF13yx62uJR2YMDJV/shiJH3"
  + "Ho+O39GiwCqm5430DYHoFk+9qd2iFzr3NW01SvZ3e41HB5KAQ5gRbchqReOq4blS+08/ckw2V9ObKj7efkYWVA+6pG/rP5bealqnjnn9Je154ZBb1/5kCwJEDOBz6Y/N"
  + "6pwxrzvSXv4P8GXoXMEFM6S6zeuO5LfvzKz2TKSTQ/l26rcG2UotS+52mjv9IrtT7lvCptya7DN5sBw3IqyTNlcq4hmR+lNiJI7TVFli3c9DwZ4B1Ls5wljX9vUXi31X"
  + "QkkuzKtR/CbiSvKi969XE6ZWnuT3LRRH+t9UBayYAKlezL8SKbArEYpuTc6r39OPUHYDX8pxqtc1DHmlS424u9AwJW6QNid0w3+ud/m6/dcPJbk86ydDM/1MsecwjE5a"
  + "wybmtGEOV/3Xq8iSi56DDlSecQ3TD9Ap9M6WFGat44YeDdAkcWba9CxdNz88n6/LhLi3fTIl/rz2Q9n8HVUGQ3MV4xv3otsQ4Y04fSJVbc1kvzyebLsYDGmOlcvIUMle"
  + "YGqcjVj9bS5fXgGVZbtcyHmpkof2djpkIKr7fBFe7ZZqC2GR/oUVStNEtC8driKDLFvzFjaKqn/l1wuWFidpkRw3ny8tNBUrURmpYJqkSZFIouPareznDWLVuYG4d5M0"
  + "mTgNNr8ShSzpmZIaeUai3i5cWshWUyKztJ1jou0eDjk9bYEpveBNjnS42h3G+fgj98W6D3c+Y/fIdzXPa5aq2Nsp8IMoxCV4RmjemSY1BZZ8pHwfZWlml/WzRGX6TY5J"
  + "5VCIPB3pl5JCe767fj4JgpoWMdqQUpmdh1RjPUOP2z5yk0jLdnhDaJQ1ye+W/pek1lYgp7SsHEBCuhM8N9P/qaezD0q0ekphZNguzEyQNqKFoKWVROboaoZqa5eqEL3g"
  + "QiQVhoWhhG1oaWYGISD8WyQOlr4TM+WaCfhcnGcy5j+NvAh2ckyql24JFFmkkhGo2oPGVsjew6iv0DEvtCedhb0Cws79SAye+ZBdX51giX89pdS++HaoD6Xzyy76YrjV"
  + "WRzf2MrlDzBCJnbxnugC3bwLD6n0kbu1wZ+4z0W8fI2dtU3GEHz7MlTWUHRjWbGZDS+VdiZVmaPOLNOAEfk6mBtueSBvLFkkY0Kor3wZawBrm7Hn4+lyw//KozLnBmpB"
  + "jKlvKEEOQs+XupBLF/3aVZeMZMSgPw6N/zmKm6I0DOkm+raX8yqUHzVjcj/lrtJ5Hq5Tuds1BjrJgduWpkkEA/+ErVkUbBMLCnzm1r0WnLx+Sf3LYkIUOAXtfCtdmRdv"
  + "JcueP//MSllNjmvqT32Lg/Tk6Pt05bLyL/SB6Hlol2mvCBGLuZuiLCyCacjPbVroP8PW66DAO6utY+6E1Za+ivIwL2ZqHwLBV6uczNBJD/Wlc813ESnu89DhR1lEgFEj"
  + "jVER5BQ4GZ1lTKZiGaKoCBNhpj5caNa8//bNPHTg0Z/hit2vWBEs0yerEEVlmDbrX9F56M5fyX+AfyCisQLh6IPGwnOSZiGKDlPfEtAPaRhVbI/Ck8FE8BETjTGRinkx"
  + "9fZLiZONQffuDliKzZtFKzqd8YT0VXzOeFE/zfp/877StiUYWUIVtsmOBEiaze2Fzt5v+1Njp5OHdOvqpG0r+x3zd03eAvSbfxDRTwudM/G/b/S885CuXd332/oB/pc/"
  + "NY+3wL+aqAmQpb0ld6Fk1H9q6ktUUhbiUl6FL3S7TSf/fcPX5Tad8I+a+p6tWZ3khbj0wt/Q3zcOd9HQrUASAoRpgSkjlsm7W6vt7JVBYAT/yqD+1bH8KGtdMuuSnyXM"
  + "ULLjZqs2T2D4QvrVsXh0M7n9fXt09svTW3nGJ+8KI0KBrjzsgtQ/5lo+SfE+xDbTIxiBb+JBrCOOI6/BRAEmdaYPsEz7QavhfN2u04z3mc5eeBxx/v3CY5upMjAYfjXC"
  + "ASiXlJFsLAHdTAdwOFFBAvai9sqwC8YANY2JKMB8wNQOoL5SjSgEqCL3mRFcqKCpEfeRNPA/HlR4lAws1gfAIp1xRjBrxKGdRcfIePC/ynKI0JQRY+rpkeYF1p3lAhsN"
  + "fglh46LAEdK6UIKRTDDRi5Nut///Pkytn3txcrLghetcPz3IxO1HZOJmyAP3MWqZp9it9QBcXdPpMSsOaYzTDtwbFsAVB+IGWHG7W+u4E2OpE1zm/sFHVKDvyRTNqf9k"
  + "IN+5F+UnyAWpgHU1qZMDvo+4XbziAOvp/pYUDnvwselkewW3dYCe8j+cmJLEzUkdr26h8X+kjo93OwNPub7hmHydCG70G0v6n3Ya4+6dbEn5n44Zn25uCUidbKKNcZvD"
  + "gW64hXXJk51h3MFK0xAOW4fb8Qo8XFeboiLA2u5LUeN2pypwO8YBOOOAg+PYJr/TYwwKF/8z8HD7FNV0Gn0M6KSgcNu7TRvraALBr8aSJ4cCqMyAk73lqdNXh4HHpDtT"
  + "ASdoNSdc2UmnmlTg4fFBStNpytTp7h7utBiHqQu8iMM6TWcG7H1Uw50I4LYPUnDHUhJ65AQblYEHY6yBh0fGkrjt4aajncDj42FjqiO0lDHOuORI25nAuwNHdClptFqw"
  + "joXg/wGyv0Kgtz0AAA==")
g = base64.b64decode(_g)[1:]
for i in range(base64.b64decode(_g)[0]):
    g = gzip.decompress(g)
g=list(g)
def gr(x,y):
    if(x>=0 and y>=0 and x<2000 and y<1007):
        return g[y*2000 + x];
    return 0;
def gw(x,y,v):
    if(x>=0 and y>=0 and x<2000 and y<1007):
        g[y*2000 + x]=v;
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
    gw(1999,1000,35)
    sa(1999998)
    return 1
def _1():
    sa(sr())
    sa(35)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(tm(sr(),2000))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),2000))
    sa(sp()+1);
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sr())
    return (15)if(sp()!=0)else(2)
def _2():
    gw(1,0,2000)
    gw(2,0,2000)
    gw(0,0,2000000)
    gw(3,0,2)
    gw(0,1,32)
    gw(1,1,32)
    gw(5,0,(gr(1,0)*10)+1)
    return 3
def _3():
    gw(tm(gr(3,0),gr(1,0)),(td(gr(3,0),gr(1,0)))+1,88)
    sa(gr(3,0)+gr(3,0))
    sa((1)if((gr(3,0)+gr(3,0))<gr(0,0))else(0))
    return 4
def _4():
    return (14)if(sp()!=0)else(5)
def _5():
    sp()
    return 6
def _6():
    global t0
    global t0
    sa(gr(3,0)+1)
    gw(3,0,gr(3,0)+1)
    sa(tm(sr(),gr(1,0)))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),gr(1,0)))
    sa(sp()+1);
    v0=sp()
    t0=gr(sp(),v0)
    t0=t0-32
    return 7
def _7():
    global t0
    return (8)if((t0)!=0)else(6)
def _8():
    return (3)if(gr(0,0)>gr(3,0))else(9)
def _9():
    gw(3,0,0)
    gw(4,0,0)
    return 10
def _10():
    global t0
    global t0
    global t0
    sa(gr(3,0)+1)
    gw(3,0,gr(3,0)+1)
    sa(tm(sr(),gr(1,0)))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),gr(1,0)))
    sa(sp()+1);
    v0=sp()
    t0=gr(sp(),v0)
    t0=t0-88
    return (12)if((t0)!=0)else(11)
def _11():
    gw(4,0,gr(3,0)+gr(4,0))
    return 12
def _12():
    return (10)if(gr(0,0)!=gr(3,0))else(13)
def _13():
    print(gr(4,0),end="",flush=True)
    return 16
def _14():
    sa(sr())
    sa(32)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(tm(sr(),gr(1,0)))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),gr(1,0)))
    sa(sp()+1);
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sp()+gr(3,0));
    sa((1)if(sr()<gr(0,0))else(0))
    return 4
def _15():
    sa(sp()-1);
    return 1
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14,_15]
c=0
while c<16:
    c=m[c]()