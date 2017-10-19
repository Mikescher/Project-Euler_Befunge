#!/usr/bin/env python3

# transpiled with BefunCompile v1.3.0 (c) 2017
import gzip, base64
_g = ("Ah+LCAAAAAAABADNWHlYU9cSp0XBCARfXNgE5KsRi5GgoEjYFFo/JDQoWokICbuAKJsxxBgigkYLKBUSlrDIEwQUJEHQAGEXEMJWglIgbNKAEAkQhLCE5EHfP/a1Aq/a"
  + "vnf/mDtz5nfm3Dsz58zcqxmxQWr5Wic1loz2244N/LZ8414c2kovUcVncKvWJirJRPtuyKaCKhmZUOewTRHf2HaNp+yqA4oyux+lnHX6fvFxkFT3vQNOGJ4G8NuwGf5w"
  + "tb59CxMXND1OlIxLRAPm4uFRtEToZy5aHJ2ZGyYuditKMNM9IxtnGoV95SIuq1xEgdb/VBFFpL5sllKbUpX6/dVvGC/JteTJ9cheB1KMr3GBzkXSSL7UR1g5u/LqeUBT"
  + "68CdzYlp1eraBpYkY4TXTSA2qVVenX8oTQXGCbDQv8QYDPd861+3EnA8PGiqIKZOw4t/fuZGA1gr27KtXfP/U/DOzjCQVsiZpgWg6ECe4t/L6H0YrC3OfGOzq0peBjTO"
  + "FxCsFEu9IlD2IyzTLUcgklB335JeCbVmVuC1W0BjKq06wXMMF0Nwx69uWP6D16J9JSg7EiMc++e8tuJTZVYolb3Nzcg/qMsVInsRcTaSW9HkHUHfzjC6sI8ibZi5tzaw"
  + "f6igBgnkJD1bATzEJLzRBeeeh0DDVkzqin5KrjfH/BsOnvzMCh5bw5egrfgR9BxobX7ZOta8K4S3LFTmlyn/KsBpv2qWBNC/NX8Ae2PCAnlTpy7ynzNe14fFRXGBHm5F"
  + "lp1I/vGDFOPYj4sz7+p/szfJA8bo0HRMFPfwyv68f/7DWW/X92lFfJV3HlIXuuKLXyvkFXXMbSYQTrQVA89EcvW9nUiQWkFCwRPLbW5zNg4dWhH0q7tyedE1SLOY15iX"
  + "rpDUYzyY+z5KSzpGPV+ZdW71aZYdHzxXayzTD/PO+Sk2viCGvW3c5W9n3K6Qs1JbrbvASOA6Fqvd1mv9J9AMisf5xHjFf4DTFkDeTw1o7a4QYwjdbDklgfAcxaUsza8G"
  + "8aqXcvEd7cW8f9fnUG8PTMaPRtfgqHUoR94vlazaQFI+nZPmC8HuVmOpN3xcxM+4f5gh1xra55s7+vuo8JL00yTknaVdE1UhCEy0A4BpzKSHpywAEGjm1+TjX7JY3tbg"
  + "2LWqbgfo/qjM2c9crYgssYfbrlzwMhqHLeWoB0SxSIWFrBUoU+mRHpC79P8ULl7odIz6pqse550evnHJI8z9aRZLDsmzyYpecteezTrpe2sFDZ+qwuxrtVztEMxvNuN1"
  + "ZXML2gfbC9k/u0EpFQLENrgzTjtiyQMxNSBkb70rADLuTl9HweYjv2QZn4GEcpMhv4ftsqEbZICaj1iQPvvthPkAxNup47mjTqQMxR5sI/cglPs9gF3l5Yz7vqpATxWJ"
  + "Iuvt/STVZstbsQ6aaH4Eb+WDVYoy8CXH3JeztsYC1OYSucVMdVvlKqUIv2vMnecqtu/ZXiF4FO7tYkBj6rg4KCtA8qzjtx2VZj0GPbzx06eoGlvTELnA4Swy7ZSyfiEs"
  + "6cHpKjuXxvZR/zsOAPiNfScfVxv5gCFba20+G0he/Ynbs7x5+rAV3KlcFzIeTFf5s0TJ8Q2QIqcbIMtaH8cI416HcyoDK8F856J+EJbm6H/bGKnLeKG+AuzeptGzzXBk"
  + "mao+EvXcyJ1u/Hlvr9npNxJuhMN2tmulAQEYqyxLC3XQaPRx0seGBg42ZvQe8cV64pUfJoYifly1U1HuFkAGk3xL3WUzGfqIA0iUZ5IPjdl46JUzLiHgUaVg/+CpMK5H"
  + "bbYMixV5UoESp5KpCoH+Hujt1bkICyK9bhoKb7hXGZA3YFcZQW0CkMFhg6jqjOtKhtTNOnCZutKb8PXQiwe1T1Hk7+AV4jaiOL6ILIjKdqGq7lYmozPp+Jn9h/gHHHWC"
  + "A54apeW7+3POM05NvPEMsvCo72d0+Gf313yGBabPZ6XSzKaNcz4Lxak3X7isPRQrWO0MX2a1XsWvZ6iRm4Nsc018EbmOb5Z6IZ7GwczTugHo61yMIvXknjgGtFJQTGrK"
  + "JsM5cc64nuqh9gYwH05j8l2CfLggIRiJEtKMCgNvL4AgefifkxyKXhAAlA7TtZvTYgh1MMg9adeNXDbYVUVrCEA68Ztv7gDLj2hB/zeD1enTquw0vOpSc4AbwvUul5hI"
  + "IaZLjtwEKmzbDehp0W+ZQkVyyS7MPDYqy5eSRT567G1ICi5FuFSh5AcJyTMWHk+/yTWwthBONU4xldxwHsrjvAIlHSrYJ+MEqDj1XMpw6VIVqw5GZ5Ye74Sc2BN1r3XR"
  + "ZMpkvAaJUqldgI3daPC87eAdG84fvuGoFDbNZGpsOSG9iLUD2R3wBjTtlrZ8EnHk0a69aSoezi8x+6xepYMNHsjLF+nKZCcWhHvGhmp11Oz4PobSGrlf75di5XSfNlDi"
  + "CZmbS6ZOfedgod9QEc1zjX50DO51VEU50En+vzbaalpooLcziqhoXbWJc9J4a76LqkQjNlyLkXlZx73aQGy6G2Dpbzt26uVNbxH+OOhmf0pXdrQCe1Z4f6d8pWnhSS21"
  + "h5PjR44pX8f7ZFoctBnsC7unt07YjrjhG19bLgt22cDPTt7YqffJCyB/PaNfCA62W9/iXsgib2J1H9+jRXmedtoC4meZG47svekAoDMVCkGuOLWPA1EWGVDe05oGxGof"
  + "Y9K/adPuzOGDvfs6BtV+gK26E/mUJjvOWAa4Uc3L4+L9hOiYjJMWoCGFgv2GrTYv69u+1gJMyTgkqHnt+sV9JDY6HCed26hgsDkw/5K1VRUz9PSQTCLA6AwMvNOl9/Ce"
  + "IOmm8CRIMuient99clGopwWCggAcizdsbeAc1tfShmeG7/xMy1hR2S9j7r0e4P7wAFQ8qFtDuG8ct+eO9ds7JVuEoXzHJ4d00oz5dhzZ4qCiN1nhfAY8QPNt818F3gCz"
  + "GlnFy8usdAKvNfndV92rdT9Ym1sm2Pyz3WqdZbpflRSW/jjG2/+XiDqRbC1N4IrlbLW6J7KojjmnUiIDSf0kkilT/9bMNsUSVhSigAz5goUUd8mxOq5xlWiR3LxS2tU1"
  + "D55S4AN4qSakA4VGzxYOA4R6GU/0fw1iOD7eriMhIO6N2fEqU5tsXuNy4HYPaDxsx3hyMhiKsf6KJ0dh+suRtWaQvsYkq2C/5kuDOdWxxc2Ry6EH8V2snc7VOv3w581C"
  + "nwFziPn4qnntEsUc4n7KdOi0bW2+GU1cj3wt+9pchTVfMa/tdkYTKXGH8KR5qZEeBOfFGHrOH4PVFCBkmc9KPXew+Om3Lax3rKF8p++tFKis4R+Q85/qoj4EwuxIQ+f+"
  + "QZZbywbbe1brAt0o6h4sD3q7oJ0f0eQd245ExXURlgdVWTy7EujBzBN2bjgnH2HNkIG1DyQPPlb2c9LRY1FcTHaPEpW9O5vO1C1ccA1SBR+gdGRcRvsiHqTXCorXYGw0"
  + "2UHmD36UXlPwl9jD03YoSkT8nunpxcmJS8IebJ+TrbmJesqTPo0UBJaUaW+fx1fE2taVZNpLZutS0U5ozbu2ddhMHpU9OeIPMyWUXTlkAzU24dhKa0gmXObZ1BJqnX1f"
  + "eTFhcQ6a+tQvLHVWdClIODTpL5ogjdgKNVGlIRgi/qokOHgBr2ia3JvyUDFscAFtcyVh4hKjxKjXXIP/hN8HNQX+ZNIoKl2A7iFdTRIHSyYGz87dFvobDcVeXRA7X52H"
  + "aqKJib3P2Wcli3HdIy1Cw7p6IQs6idB9Uf2e+rZnYHK4PM/sO3NivJhRRMQHiyZG6pQQ5T+FLIiwdw2FbL+achFhdvTVWJyfft61vMnHLZ3DhsI69OJlU4LKjFiUgPui"
  + "t5g8Z0JoWxwSjwRP8b/lTtmj6tj2qVdg6n1JF80d+/rMEejLmuJDhNdHg1w0ykyZxmKR3K7uDgTb/ueOu5kl3YPvuTMHrj8Ooszr244Tt8zmjE++nxFPDqcWp/ZN3c1k"
  + "vweW4YSXYKYSffbIe/GgH0oYHKI+HzExMWNAaCOIDAgBGMPFt+9nRVPd3dTBkZGBS0khwTDTkERxMDZIVBPn1ZJXEhIyQeVBFcvnalJDwAuw2a3li7LDd1OJM8+Serv8"
  + "hnqfsLtn50pFog5b88Xcas0+olnyw74hHHT8GklC9DN7vDCibrrItWWjL5YXiYcuX1kgBgcZEjYkEUeCg8SV7Lq6d+8mFkxEd0pTUVPzLfZ5kpHR6cFXPPYr3hJFl3ub"
  + "l8lFyT+em20aS5+2bRnvnDrXb0vSNHcjIud1eHOptWbfaYLY5re+Mze2QT+YLCreIpGl37oW/KhaVupf8/rlo0wYAAA=")
g = base64.b64decode(_g)[1:]
for i in range(base64.b64decode(_g)[0]):
    g = gzip.decompress(g)
g=list(g)
def gr(x,y):
    if(x>=0 and y>=0 and x<486 and y<1047):
        return g[y*486 + x];
    return 0;
def gw(x,y,v):
    if(x>=0 and y>=0 and x<486 and y<1047):
        g[y*486 + x]=v;
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
    gw(1,0,486)
    gw(2,0,1029)
    gw(4,0,500094)
    gw(3,0,2)
    gw(0,3,32)
    gw(1,3,32)
    gw(1,1,1000000)
    gw(2,1,19)
    gw(2,2,0)
    gw(3,2,1)
    gw(4,2,2)
    sa(gr(4,0)-1)
    sa(gr(4,0)-1)
    gw(tm(gr(4,0)-1,gr(1,0)),(td(gr(4,0)-1,gr(1,0)))+3,35)
    return 1
def _1():
    return (29)if(sp()!=0)else(2)
def _2():
    gw(tm(gr(3,0),gr(1,0)),(td(gr(3,0),gr(1,0)))+3,88)
    sp();
    sa(gr(3,0)+gr(3,0))
    sa((1)if((gr(3,0)+gr(3,0))<gr(4,0))else(0))
    return 3
def _3():
    return (28)if(sp()!=0)else(4)
def _4():
    sp();
    return 5
def _5():
    global t0
    sa(gr(3,0)+1)
    sa(gr(3,0)+1)
    gw(3,0,gr(3,0)+1)
    sa(tm(sp(),gr(1,0)))

    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),gr(1,0)))

    sa(sp()+3)

    v0=sp()
    t0=gr(sp(),v0)
    t0=t0-32
    return 6
def _6():
    global t0
    return (7)if((t0)!=0)else(5)
def _7():
    return (8)if(gr(4,0)>gr(3,0))else(9)
def _8():
    sa(0)
    return 2
def _9():
    gw(3,0,0)
    sa(0)
    sa(gr(0,3)-88)
    return 10
def _10():
    return (11)if(sp()!=0)else(27)
def _11():
    sa(sp()+1)


    return (12)if((sr()-gr(4,0))!=0)else(13)
def _12():
    sa(sr());
    sa(tm(sr(),gr(1,0)))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),gr(1,0)))

    sa(sp()+3)

    v0=sp()
    sa(gr(sp(),v0))
    sa(sp()-88)
    return 10
def _13():
    gw(5,0,gr(3,0))
    gw(1,2,((gr(1,1)*gr(1,1))-gr(1,1))/2)
    sp();
    sa(gr(2,1)-1)
    sa(gr(2,1)-1)
    gw(gr(2,1)+8,1,32)
    return 14
def _14():
    return (26)if(sp()!=0)else(15)
def _15():
    gw(9,1,0)
    sp();
    return 16
def _16():
    return (18)if(gr(4,2)>gr(1,1))else(17)
def _17():
    gw(1,2,gr(3,2)+(gr(1,2)-(gr(4,2)-1)))
    return 18
def _18():
    return (25)if((((1)if((gr(2,1)-1)>gr(2,2))else(0))*((1)if((gr(tm(gr(gr(2,2)+9,1),gr(1,0)),(td(gr(gr(2,2)+9,1),gr(1,0)))+3)*gr(4,2))<=gr(1,1))else(0)))!=0)else(19)
def _19():
    gw(4,2,td(gr(4,2),gr(tm(gr(gr(2,2)+9,1),gr(1,0)),(td(gr(gr(2,2)+9,1),gr(1,0)))+3)))
    gw(3,2,td(gr(3,2),gr(tm(gr(gr(2,2)+9,1),gr(1,0)),(td(gr(gr(2,2)+9,1),gr(1,0)))+3)-((0)if(((1)if(gr(2,2)>0)else(0))*((0)if(gr(gr(2,2)+9,1)-gr(gr(2,2)+8,1)!=0)else(1))!=0)else(1))))
    gw(gr(2,2)+9,1,gr(gr(2,2)+9,1)+1)
    return 20
def _20():
    return (24)if((((1)if(gr(5,0)>gr(gr(2,2)+9,1))else(0))*((1)if((gr(4,2)*gr(tm(gr(gr(2,2)+9,1),gr(1,0)),(td(gr(gr(2,2)+9,1),gr(1,0)))+3))<=gr(1,1))else(0)))!=0)else(21)
def _21():
    global t0
    gw(gr(2,2)+9,1,32)
    t0=(1)if(0>(gr(2,2)-1))else(0)
    gw(2,2,gr(2,2)-1)

    return (22)if((t0)!=0)else(23)
def _22():
    print(gr(1,2),end=" ",flush=True)
    return 30
def _23():
    global t0
    global t1
    global t2
    t0=gr(tm(gr(gr(2,2)+9,1),gr(1,0)),(td(gr(gr(2,2)+9,1),gr(1,0)))+3)
    gw(4,2,td(gr(4,2),gr(tm(gr(gr(2,2)+9,1),gr(1,0)),(td(gr(gr(2,2)+9,1),gr(1,0)))+3)))
    t0=t0-((0)if(((1)if(gr(2,2)>0)else(0))*((0)if(gr(gr(2,2)+9,1)-gr(gr(2,2)+8,1)!=0)else(1))!=0)else(1))
    t1=gr(3,2)
    t2=td(t1,t0)
    gw(3,2,t2)
    gw(gr(2,2)+9,1,gr(gr(2,2)+9,1)+1)
    return 20
def _24():
    global t0
    t0=gr(tm(gr(gr(2,2)+9,1),gr(1,0)),(td(gr(gr(2,2)+9,1),gr(1,0)))+3)-1
    gw(4,2,gr(tm(gr(gr(2,2)+9,1),gr(1,0)),(td(gr(gr(2,2)+9,1),gr(1,0)))+3)*gr(4,2))
    t0=t0*gr(3,2)
    gw(3,2,t0)
    return 16
def _25():
    global t0
    sa(gr(2,2)+9)
    gw(2,2,gr(2,2)+1)
    sa(1)
    v0=sp()
    sa(gr(sp(),v0))
    sa(sr());
    gw(gr(2,2)+9,1,sp())
    sa(tm(sr(),gr(1,0)))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),gr(1,0)))

    sa(sp()+3)

    v0=sp()
    t0=gr(sp(),v0)
    gw(4,2,t0*gr(4,2))
    t0=t0*gr(3,2)
    gw(3,2,t0)
    return 16
def _26():
    sa(sp()-1)

    sa(sr());
    sa(32)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+9)

    sa(1)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sr());
    return 14
def _27():
    sa(sr());
    sa(gr(3,0))
    sa(gr(3,0))
    gw(3,0,gr(3,0)+1)
    sa(tm(sp(),gr(1,0)))

    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),gr(1,0)))

    sa(sp()+3)

    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    return 11
def _28():
    sa(sr());
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

    sa(sp()+3)

    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sp()+gr(3,0))

    sa((1)if(sr()<gr(4,0))else(0))
    return 3
def _29():
    sa(sp()-1)

    sa(sr());
    sa(35)
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

    sa(sp()+3)

    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sr());
    return 1
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14,_15,_16,_17,_18,_19,_20,_21,_22,_23,_24,_25,_26,_27,_28,_29]
c=0
while c<30:
    c=m[c]()
