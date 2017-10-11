#!/usr/bin/env python2

# transpiled with BefunCompile v1.2.0 (c) 2017
import sys
import zlib, base64
_g = ("AR+LCAAAAAAABADVVsFuwyAM/RUK7ALKhrNGbVBk7UOi9NBVuXLilI8fISRNm5S1nbq074CMjeQn7Ae25CXAeyxNJAoWx9L0Xg3WpKXSxdI0IkBKKBICiW6WpvI77NIE"
  + "JnClFXR/oL7ELT2jgADvK24NnNQf7XENHm7/GLVlDS4Fgqo1SFAmNdF7wpwe9lTgVhm9VXWWyaH+qN3uTTeooV41CCUY5/jQq4ZgqWNREY36HG0KHDeZY1A7Z5ZlWyFE"
  + "wqodd1tIoo2IXFedxdlx7eDv+d6olQGueDh6pKv5y+RDxU8TTPiO1hujPEQHMlwpzJNVT+zkMFzIMMGiMi/UuUPk4lOCyNcXH8nn0hDSPV3nAuSnY/40GqLftNePOxdX"
  + "0BIamqVx9SQUdMDmS4JsWNmkiW7S0Dxu/XTmGtmWY+81We9Jetf3mMDwWRWk0XX6b+PKWIUsNFJXTGLZGbcRKv5ogn4mctL22sKNN9LaqdDZziC9vpBs2vfCK88d0am3"
  + "VBipwoOAkhWlZsVOvn89mHdg1bcXqpauuaLbkD+gJTv8AFvIfdyeDQAA")
g = base64.b64decode(_g)[1:]
for i in range(ord(base64.b64decode(_g)[0])):
    g = zlib.decompress(g, 16+zlib.MAX_WBITS)
g=list(map(ord, g))
def gr(x,y):
    if(x>=0 and y>=0 and x<166 and y<21):
        return g[y*166 + x];
    return 0;
def gw(x,y,v):
    if(x>=0 and y>=0 and x<166 and y<21):
        g[y*166 + x]=v;
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
    sa(31)
    return 1
def _1():
    sa(sr());
    sa(0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(2)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sp()-1);

    sa(sr());
    return 2
def _2():
    return (1)if(sp()!=0)else(3)
def _3():
    gw(1,0,1)
    gw(8,0,9999)
    sp();
    sa(9)
    sa(9)
    return 4
def _4():
    sa(gr(8,0))
    sa(9)
    return 5
def _5():
    sa(sr());
    sa(0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(1)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sp()-1);

    sa(sr());
    return 6
def _6():
    return (5)if(sp()!=0)else(7)
def _7():
    sp();
    sa(sr());
    return 8
def _8():
    sa(tm(sr(),10))
    sa(sr());

    return (9)if(sp()!=0)else(75)
def _9():
    global t0
    sa(sr());
    sa(1)
    v0=sp()
    t0=gr(sp(),v0)
    t0=(0)if(t0!=0)else(1)

    return (10)if((t0)!=0)else(75)
def _10():
    sa(1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(1)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(td(sp(),10))

    sa(sr());
    sa((0)if(sp()!=0)else(1))

    return (11)if(sp()!=0)else(8)
def _11():
    sp();
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr());
    return 12
def _12():
    sa(tm(sr(),10))
    sa(sr());

    return (13)if(sp()!=0)else(75)
def _13():
    global t0
    sa(sr());
    sa(1)
    v0=sp()
    t0=gr(sp(),v0)
    t0=(0)if(t0!=0)else(1)

    return (14)if((t0)!=0)else(75)
def _14():
    sa(1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(1)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(td(sp(),10))

    sa(sr());
    sa((0)if(sp()!=0)else(1))

    return (15)if(sp()!=0)else(12)
def _15():
    sp();
    sa(sp()*sp());

    sa(sr());
    return 16
def _16():
    sa(tm(sr(),10))
    sa(sr());

    return (17)if(sp()!=0)else(73)
def _17():
    global t0
    sa(sr());
    sa(1)
    v0=sp()
    t0=gr(sp(),v0)
    t0=(0)if(t0!=0)else(1)

    return (18)if((t0)!=0)else(73)
def _18():
    sa(1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(1)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(td(sp(),10))

    sa(sr());
    sa((0)if(sp()!=0)else(1))

    return (19)if(sp()!=0)else(16)
def _19():
    sp();
    sa(9)
    return 20
def _20():
    sa(sr());
    sa(1)
    v0=sp()
    sa(gr(sp(),v0))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()-1);

    sa(sr());
    return 21
def _21():
    return (20)if(sp()!=0)else(22)
def _22():
    global t0
    sp();
    sa(sp()+sp());

    t0=sp()
    sa(sp()+t0);

    sa(sp()+sp());

    sa(sp()+sp());

    sa(sp()+sp());

    sa(sp()+sp());

    sa(sp()+sp());

    sa(sp()+sp());

    sa(sp()-9);

    sa((0)if(sp()!=0)else(1))

    return (72)if(sp()!=0)else(23)
def _23():
    global t0
    t0=gr(8,0)-1

    return (71)if(gr(8,0)!=1001)else(24)
def _24():
    sa(sp()-1);


    return (70)if(sr()!=1)else(25)
def _25():
    sp();
    gw(8,0,999)
    sa(99)
    sa(99)
    return 26
def _26():
    sa(gr(8,0))
    sa(9)
    return 27
def _27():
    sa(sr());
    sa(0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(1)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sp()-1);

    sa(sr());
    return 28
def _28():
    return (27)if(sp()!=0)else(29)
def _29():
    sp();
    sa(sr());
    return 30
def _30():
    sa(tm(sr(),10))
    sa(sr());

    return (31)if(sp()!=0)else(69)
def _31():
    global t0
    sa(sr());
    sa(1)
    v0=sp()
    t0=gr(sp(),v0)
    t0=(0)if(t0!=0)else(1)

    return (32)if((t0)!=0)else(69)
def _32():
    sa(1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(1)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(td(sp(),10))

    sa(sr());
    sa((0)if(sp()!=0)else(1))

    return (33)if(sp()!=0)else(30)
def _33():
    sp();
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr());
    return 34
def _34():
    sa(tm(sr(),10))
    sa(sr());

    return (35)if(sp()!=0)else(69)
def _35():
    global t0
    sa(sr());
    sa(1)
    v0=sp()
    t0=gr(sp(),v0)
    t0=(0)if(t0!=0)else(1)

    return (36)if((t0)!=0)else(69)
def _36():
    sa(1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(1)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(td(sp(),10))

    sa(sr());
    sa((0)if(sp()!=0)else(1))

    return (37)if(sp()!=0)else(34)
def _37():
    sp();
    sa(sp()*sp());

    sa(sr());
    return 38
def _38():
    sa(tm(sr(),10))
    sa(sr());

    return (39)if(sp()!=0)else(67)
def _39():
    global t0
    sa(sr());
    sa(1)
    v0=sp()
    t0=gr(sp(),v0)
    t0=(0)if(t0!=0)else(1)

    return (40)if((t0)!=0)else(67)
def _40():
    sa(1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(1)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(td(sp(),10))

    sa(sr());
    sa((0)if(sp()!=0)else(1))

    return (41)if(sp()!=0)else(38)
def _41():
    sp();
    sa(9)
    return 42
def _42():
    sa(sr());
    sa(1)
    v0=sp()
    sa(gr(sp(),v0))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()-1);

    sa(sr());
    return 43
def _43():
    return (42)if(sp()!=0)else(44)
def _44():
    global t0
    sp();
    sa(sp()+sp());

    t0=sp()
    sa(sp()+t0);

    sa(sp()+sp());

    sa(sp()+sp());

    sa(sp()+sp());

    sa(sp()+sp());

    sa(sp()+sp());

    sa(sp()+sp());

    sa(sp()-9);

    sa((0)if(sp()!=0)else(1))

    return (66)if(sp()!=0)else(45)
def _45():
    sa(gr(8,0)-1)

    return (48)if(gr(8,0)!=101)else(46)
def _46():
    sp();
    sa(sp()-1);


    return (47)if(sr()!=10)else(49)
def _47():
    sa(999)
    return 48
def _48():
    gw(8,0,sp())
    sa(sr());
    return 26
def _49():
    gw(8,0,32)
    gw(7,0,gr(8,0)-1)
    sp();
    return 50
def _50():
    global t0
    t0=gr(gr(8,0),2)

    return (52)if((gr(gr(8,0),2))==0)else(51)
def _51():
    global t0
    t0=t0-gr(gr(7,0),2)

    return (52)if((t0)!=0)else(65)
def _52():
    global t0
    t0=gr(7,0)

    return (64)if(gr(7,0)!=1)else(53)
def _53():
    global t0
    t0=gr(8,0)

    return (63)if(gr(8,0)!=2)else(54)
def _54():
    sa(0)
    sa(31)
    return 55
def _55():
    sa(sr());
    sa(2)
    v0=sp()
    sa(gr(sp(),v0))
    sa(sr());

    return (56)if(sp()!=0)else(62)
def _56():
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()-1);

    sa(sr());
    return 57
def _57():
    return (55)if(sp()!=0)else(58)
def _58():
    sp();
    return 59
def _59():
    sa(sp()+sp());

    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr());

    return (61)if(sp()!=0)else(60)
def _60():
    sa(sp()+sp());

    sys.stdout.write(str(sp())+" ")
    sys.stdout.flush()
    return 76
def _61():
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    return 59
def _62():
    sp();
    sa(sp()-1);

    sa(sr());
    return 57
def _63():
    global t0
    t0=t0-1
    gw(8,0,t0)
    gw(7,0,gr(8,0)-1)
    return 50
def _64():
    global t0
    t0=t0-1
    gw(7,0,t0)
    return 50
def _65():
    gw(gr(7,0),2,0)
    return 52
def _66():
    sa(gr(1,0))
    gw(1,0,gr(1,0)+1)
    sa(2)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    return 45
def _67():
    sp();
    return 68
def _68():
    global t0
    sp();
    sp();
    t0=0
    return 45
def _69():
    sp();
    return 67
def _70():
    gw(8,0,9999)
    sa(sr());
    return 4
def _71():
    global t0
    gw(8,0,t0)
    sa(sr());
    return 4
def _72():
    sa(gr(1,0))
    gw(1,0,gr(1,0)+1)
    sa(2)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    return 23
def _73():
    sp();
    return 74
def _74():
    global t0
    sp();
    sp();
    t0=0
    return 23
def _75():
    sp();
    return 73
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14,_15,_16,_17,_18,_19,_20,_21,_22,_23,_24,_25,_26,_27,_28,_29,_30,_31,_32,_33,_34,_35,_36,_37,_38,_39,_40,_41,_42,_43,_44,_45,_46,_47,_48,_49,_50,_51,_52,_53,_54,_55,_56,_57,_58,_59,_60,_61,_62,_63,_64,_65,_66,_67,_68,_69,_70,_71,_72,_73,_74,_75]
c=0
while c<76:
    c=m[c]()
