#!/usr/bin/env python3

# transpiled with BefunCompile v1.3.0 (c) 2017
import gzip, base64
_g = ("AR+LCAAAAAAABADVVsFuwyAM/RUK7ALKhrNGbVBk7UOi9NBVuXLilI8fISRNm5S1nbq074CMjeQn7Ae25CXAeyxNJAoWx9L0Xg3WpKXSxdI0IkBKKBICiW6WpvI77NIE"
  + "JnClFXR/oL7ELT2jgADvK24NnNQf7XENHm7/GLVlDS4Fgqo1SFAmNdF7wpwe9lTgVhm9VXWWyaH+qN3uTTeooV41CCUY5/jQq4ZgqWNREY36HG0KHDeZY1A7Z5ZlWyFE"
  + "wqodd1tIoo2IXFedxdlx7eDv+d6olQGueDh6pKv5y+RDxU8TTPiO1hujPEQHMlwpzJNVT+zkMFzIMMGiMi/UuUPk4lOCyNcXH8nn0hDSPV3nAuSnY/40GqLftNePOxdX"
  + "0BIamqVx9SQUdMDmS4JsWNmkiW7S0Dxu/XTmGtmWY+81We9Jetf3mMDwWRWk0XX6b+PKWIUsNFJXTGLZGbcRKv5ogn4mctL22sKNN9LaqdDZziC9vpBs2vfCK88d0am3"
  + "VBipwoOAkhWlZsVOvn89mHdg1bcXqpauuaLbkD+gJTv8AFvIfdyeDQAA")
g = base64.b64decode(_g)[1:]
for i in range(base64.b64decode(_g)[0]):
    g = gzip.decompress(g)
g=list(g)
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
    sa(31)
    return 1
def _1():
    return (2)if(sp()!=0)else(3)
def _2():
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
    sa(sp()-1)

    sa(sr());
    return 1
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
    sa(9)
    return 5
def _5():
    return (6)if(sp()!=0)else(7)
def _6():
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
    sa(sp()-1)

    sa(sr());
    return 5
def _7():
    sp();
    sa(sr());
    return 8
def _8():
    sa(sr()%10)
    sa(sr());

    return (9)if(sp()!=0)else(79)
def _9():
    global t0
    sa(sr());
    sa(1)
    v0=sp()
    t0=gr(sp(),v0)

    return (79)if((t0)!=0)else(10)
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
    sa(sp()/10);

    sa(sr());

    return (8)if(sp()!=0)else(11)
def _11():
    sp();
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr());
    return 12
def _12():
    sa(sr()%10)
    sa(sr());

    return (13)if(sp()!=0)else(79)
def _13():
    global t0
    sa(sr());
    sa(1)
    v0=sp()
    t0=gr(sp(),v0)

    return (79)if((t0)!=0)else(14)
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
    sa(sp()/10);

    sa(sr());

    return (12)if(sp()!=0)else(15)
def _15():
    sp();
    sa(sp()*sp());

    sa(sr());
    return 16
def _16():
    sa(sr()%10)
    sa(sr());

    return (17)if(sp()!=0)else(78)
def _17():
    global t0
    sa(sr());
    sa(1)
    v0=sp()
    t0=gr(sp(),v0)

    return (78)if((t0)!=0)else(18)
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
    sa(sp()/10);

    sa(sr());

    return (16)if(sp()!=0)else(19)
def _19():
    sp();
    sa(9)
    sa(9)
    return 20
def _20():
    return (21)if(sp()!=0)else(22)
def _21():
    sa(sr());
    sa(1)
    v0=sp()
    sa(gr(sp(),v0))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()-1)

    sa(sr());
    return 20
def _22():
    sp();
    sa(sp()+sp());

    sa(sp()+sp());

    sa(sp()+sp());

    sa(sp()+sp());

    sa(sp()+sp());

    sa(sp()+sp());

    sa(sp()+sp());

    sa(sp()+sp());

    sa(sp()-9)

    sa((0)if(sp()!=0)else(1))
    return 23
def _23():
    global t0
    return (77)if((t0)!=0)else(24)
def _24():
    sp();
    return 25
def _25():
    global t0
    t0=gr(8,0)-1

    return (76)if(gr(8,0)!=1001)else(26)
def _26():
    sa(sp()-1)


    return (27)if(sr()!=1)else(28)
def _27():
    gw(8,0,9999)
    sa(sr());
    return 4
def _28():
    gw(8,0,999)
    sp();
    sa(99)
    sa(99)
    return 29
def _29():
    sa(gr(8,0))
    sa(9)
    sa(9)
    return 30
def _30():
    return (31)if(sp()!=0)else(32)
def _31():
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
    sa(sp()-1)

    sa(sr());
    return 30
def _32():
    sp();
    sa(sr());
    return 33
def _33():
    sa(sr()%10)
    sa(sr());

    return (34)if(sp()!=0)else(75)
def _34():
    global t0
    sa(sr());
    sa(1)
    v0=sp()
    t0=gr(sp(),v0)

    return (75)if((t0)!=0)else(35)
def _35():
    sa(1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(1)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sp()/10);

    sa(sr());

    return (33)if(sp()!=0)else(36)
def _36():
    sp();
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr());
    return 37
def _37():
    sa(sr()%10)
    sa(sr());

    return (38)if(sp()!=0)else(75)
def _38():
    global t0
    sa(sr());
    sa(1)
    v0=sp()
    t0=gr(sp(),v0)

    return (75)if((t0)!=0)else(39)
def _39():
    sa(1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(1)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sp()/10);

    sa(sr());

    return (37)if(sp()!=0)else(40)
def _40():
    sp();
    sa(sp()*sp());

    sa(sr());
    return 41
def _41():
    sa(sr()%10)
    sa(sr());

    return (42)if(sp()!=0)else(74)
def _42():
    global t0
    sa(sr());
    sa(1)
    v0=sp()
    t0=gr(sp(),v0)

    return (74)if((t0)!=0)else(43)
def _43():
    sa(1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(1)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sp()/10);

    sa(sr());

    return (41)if(sp()!=0)else(44)
def _44():
    sp();
    sa(9)
    sa(9)
    return 45
def _45():
    return (46)if(sp()!=0)else(47)
def _46():
    sa(sr());
    sa(1)
    v0=sp()
    sa(gr(sp(),v0))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()-1)

    sa(sr());
    return 45
def _47():
    sp();
    sa(sp()+sp());

    sa(sp()+sp());

    sa(sp()+sp());

    sa(sp()+sp());

    sa(sp()+sp());

    sa(sp()+sp());

    sa(sp()+sp());

    sa(sp()+sp());

    sa(sp()-9)

    sa((0)if(sp()!=0)else(1))
    return 48
def _48():
    global t0
    return (73)if((t0)!=0)else(49)
def _49():
    sp();
    return 50
def _50():
    global t0
    t0=gr(8,0)-1

    return (72)if(gr(8,0)!=101)else(51)
def _51():
    sa(sp()-1)


    return (70)if(sr()!=10)else(52)
def _52():
    gw(8,0,32)
    sp();
    return 53
def _53():
    gw(7,0,gr(8,0)-1)
    return 54
def _54():
    global t0
    t0=gr(gr(8,0),2)

    return (56)if((gr(gr(8,0),2))==0)else(55)
def _55():
    global t0
    t0=t0-gr(gr(7,0),2)

    return (56)if((t0)!=0)else(69)
def _56():
    global t0
    t0=gr(7,0)

    return (68)if(gr(7,0)!=1)else(57)
def _57():
    global t0
    t0=gr(8,0)

    return (67)if(gr(8,0)!=2)else(58)
def _58():
    sa(0)
    sa(31)
    sa(31)
    return 59
def _59():
    return (60)if(sp()!=0)else(63)
def _60():
    sa(sr());
    sa(2)
    v0=sp()
    sa(gr(sp(),v0))
    sa(sr());

    return (61)if(sp()!=0)else(62)
def _61():
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()-1)

    sa(sr());
    return 59
def _62():
    sp();
    sa(sp()-1)

    sa(sr());
    return 59
def _63():
    sp();
    return 64
def _64():
    sa(sp()+sp());

    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr());

    return (66)if(sp()!=0)else(65)
def _65():
    sa(sp()+sp());

    print(sp(),end=" ",flush=True)
    return 80
def _66():
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    return 64
def _67():
    global t0
    t0=t0-1
    gw(8,0,t0)
    return 53
def _68():
    global t0
    t0=t0-1
    gw(7,0,t0)
    return 54
def _69():
    gw(gr(7,0),2,0)
    return 56
def _70():
    gw(8,0,999)
    return 71
def _71():
    sa(sr());
    return 29
def _72():
    global t0
    gw(8,0,t0)
    return 71
def _73():
    sa(gr(1,0))
    gw(1,0,gr(1,0)+1)
    sa(2)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    return 50
def _74():
    global t0
    sp();
    t0=0
    sp();
    sp();
    sa(0)
    return 48
def _75():
    sp();
    return 74
def _76():
    global t0
    gw(8,0,t0)
    sa(sr());
    return 4
def _77():
    sa(gr(1,0))
    gw(1,0,gr(1,0)+1)
    sa(2)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    return 25
def _78():
    global t0
    sp();
    t0=0
    sp();
    sp();
    sa(0)
    return 23
def _79():
    sp();
    return 78
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14,_15,_16,_17,_18,_19,_20,_21,_22,_23,_24,_25,_26,_27,_28,_29,_30,_31,_32,_33,_34,_35,_36,_37,_38,_39,_40,_41,_42,_43,_44,_45,_46,_47,_48,_49,_50,_51,_52,_53,_54,_55,_56,_57,_58,_59,_60,_61,_62,_63,_64,_65,_66,_67,_68,_69,_70,_71,_72,_73,_74,_75,_76,_77,_78,_79]
c=0
while c<80:
    c=m[c]()
