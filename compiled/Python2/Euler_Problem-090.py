#!/usr/bin/env python2

# transpiled with BefunCompile v1.3.0 (c) 2017
import sys
import zlib, base64
_g = ("AR+LCAAAAAAABADtVc1uIyEMfhVPmEqrQbM1zE8yCKFK+wDdYw4R0xtXTpz68GuYIZm/tg+wsdoEbGNsfx9OgOt4vb6/A8sCGwl9qbc6MMAcMATGgV2AKfoLTJsAEq6P"
  + "UIz2vL0JLyV3UhaOdkrDaFk9qBfedZXyIjkIchDkQDv1mgxqDCAcDOt4e++Y2xgWAfc3zgE1yB4agD+LMvy2MGb7EthUMKU/ec09Ycs+iFp9lh9QGZToL0bhbeDoFQtj"
  + "iVJ4lNIPUdty4dOXnIxdx21wyAdP/7cirpRSqQxjJfApI1uL+R5tEe/LuzZrIj5lORYUWdTAUs6sIFgs++id1NA0O+zuYg+1U5GmnBzCeFn5muNDO3n77ZCuN0rUt1j2"
  + "3WDS5+U4TG4YbA6G7PA5YT5ExIkC0O+puZIw8UvpzcEu67OjNPPi2/pshsLOBw0Tj5whp20X9X4br9y+NvIuy4zBUli5U+3E0MXEgqWoYq/L6ref4hUZrdUlX9wtpevr"
  + "SL8xbCz3vVUHB+1u4MTyF/AzuQ64e7KQeSO/400aPYOm0LCOJ4/KCdMYibyRD95I4s2sXwZJb5f4RYOAtPyoyC95E3Omd7vgjZ1PSM9d9B4O4h3whi14E1mkF77m5Xb6"
  + "e3ptGksXt1sEjzjyBW9m4liKpm4Om3gJQuB967GlmcyHNk7lvk0tWSa5mp0ssJ1l6ieL+Brpinbg0vGOOmpadB06Thdj29NDE2SjAUtrmdaSfESyYLKIZAHahKCttpLy"
  + "EQQYEnZDidDSrwOpkCCl8dtpH9NGL2Y3SkCyqBJJNbu1mg5pdof9gUBepZIXrAgL4wovlt0NAUVgCP7o9mPFNoOD2jQbJwxM0zjuVIOujnQv7Rz1fqzePSyduPTjAKcn"
  + "0p2rGorPnGuSmTYGe/R4Rj+EJaRD0pFNz62wr0SS20tkSpyyAY6mGukr6bDPv+RlOHDZHDO3QL+DujrBr5Pe1Wg4pRcfU+zgaI2iJ+bO6GTFz5MhvjJS9OgUfX3Q1rSX"
  + "SlUVb9Bb9pSnPOUp/6n8A5fdc+wQDgAA")
g = base64.b64decode(_g)[1:]
for i in range(ord(base64.b64decode(_g)[0])):
    g = zlib.decompress(g, 16+zlib.MAX_WBITS)
g=list(map(ord, g))
def gr(x,y):
    if(x>=0 and y>=0 and x<80 and y<45):
        return g[y*80 + x];
    return 0;
def gw(x,y,v):
    if(x>=0 and y>=0 and x<80 and y<45):
        g[y*80 + x]=v;
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
    gw(3,3,29)
    gw(2,0,0)
    gw(17,0,0)
    sa(8)
    sa(8)
    return 1
def _1():
    return (94)if(sp()!=0)else(2)
def _2():
    gw(2,1,0)
    gw(2,2,0)
    gw(13,1,0)
    gw(13,2,0)
    sp();
    sa(9)
    sa(9)
    return 3
def _3():
    return (93)if(sp()!=0)else(4)
def _4():
    sp();
    sa(9)
    sa(9)
    return 5
def _5():
    return (85)if(sp()!=0)else(6)
def _6():
    sp();

    return (7)if((((1)if(gr(2,1)>6)else(0))+((1)if(gr(2,2)>6)else(0)))!=0)else(13)
def _7():
    gw(17,0,(0)if((gr(17,0))!=0)else(1))
    sa(8)
    sa(8)
    sa(gr(17,0))
    return 8
def _8():
    return (9)if(sp()!=0)else(10)
def _9():
    sp();
    sp();
    sa(0)
    return 2
def _10():
    return (12)if(sp()!=0)else(11)
def _11():
    sys.stdout.write(str(gr(2,0))+" ")
    sys.stdout.flush()

    sp();
    return 95
def _12():
    sa(sp()-1)

    sa(sr());
    sa(sr());
    sa(sr());
    sa((0)if((gr(sr()+9,0))!=0)else(1))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+9)

    sa(0)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sp()+9)

    sa(0)
    v0=sp()
    sa(gr(sp(),v0))
    return 8
def _13():
    return (84)if(gr(2,1)!=6)else(14)
def _14():
    sa(2)
    return 15
def _15():
    return (83)if(gr(2,2)!=6)else(16)
def _16():
    sa(2)
    return 17
def _17():
    gw(4,0,((0)if((gr(10,1))!=0)else(1))+gr(13,1))
    gw(5,0,((0)if((gr(10,2))!=0)else(1))+gr(13,2))
    sa(0)
    return 18
def _18():
    gw(6,0,0)
    gw(7,0,0)
    gw(6,0,gr(13,1)+(gr(6,0)*2))
    sa(8)
    sa(9)
    return 19
def _19():
    return (82)if(sp()!=0)else(20)
def _20():
    gw(7,0,gr(13,2)+(gr(7,0)*2))
    sp();
    sa(8)
    sa(9)
    return 21
def _21():
    return (81)if(sp()!=0)else(22)
def _22():
    sp();
    sa(gr(7,0))
    sa(gr(6,0))

    return (23)if(gr(6,0)>gr(7,0))else(24)
def _23():
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    return 24
def _24():
    global t0
    sa(sp()*1024)

    sa(sp()+sp());

    t0=sp()
    gw(3,0,t0)
    sa(1279)
    sa(gr(79,15+gr(3,3)))
    sa(gr(79,15+gr(3,3))-gr(3,0))
    return 25
def _25():
    return (26)if(sp()!=0)else(80)
def _26():
    sa(sp()-35)


    return (79)if(sp()!=0)else(27)
def _27():
    sa(gr(3,0))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr()%80)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()/80);

    sa(sp()+gr(3,3))

    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    gw(2,0,gr(2,0)+1)
    return 28
def _28():
    sa(sp()+1)

    sa(sr());

    return (29)if(sp()!=0)else(78)
def _29():
    sa(sp()-1)

    sa(sr());

    return (30)if(sp()!=0)else(76)
def _30():
    sa(sp()-1)

    sa(sr());

    return (31)if(sp()!=0)else(75)
def _31():
    sa(sp()-1)

    sa(sr());

    return (32)if(sp()!=0)else(33)
def _32():
    return 95
def _33():
    gw(10,1,1)
    gw(13,1,0)
    gw(10,2,1)
    gw(13,2,0)
    sp();
    return 34
def _34():
    return (36)if((gr(4,0))!=0)else(35)
def _35():
    gw(10,1,0)
    gw(13,1,1)
    sa(1)
    return 18
def _36():
    return (37)if((gr(5,0))!=0)else(74)
def _37():
    sa(sr());

    return (38)if(sp()!=0)else(73)
def _38():
    sa(sp()-1)

    sa(sr());

    return (39)if(sp()!=0)else(60)
def _39():
    sa(sp()-1)

    sa(sr());

    return (32)if(sp()!=0)else(40)
def _40():
    sp();
    return 41
def _41():
    global t0
    t0=1
    sa(sr());

    return (42)if(sp()!=0)else(59)
def _42():
    sa(sp()-1)

    sa(sr());

    return (43)if(sp()!=0)else(45)
def _43():
    sa(sp()-1)

    sa(sr());

    return (32)if(sp()!=0)else(44)
def _44():
    sp();
    gw(17,0,(0)if((gr(17,0))!=0)else(1))
    sa(8)
    sa(8)
    sa(gr(17,0))
    return 8
def _45():
    sp();
    return 46
def _46():
    sa(sr());
    sa(0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+4)

    sa(1)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sr()-1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    return 47
def _47():
    return (48)if(sp()!=0)else(44)
def _48():
    sa(gr(sr()+4,1))
    return 49
def _49():
    return (58)if(sp()!=0)else(50)
def _50():
    sa(sr());
    sa(1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+4)

    sa(1)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())

    return (52)if(gr(2,1)!=5)else(51)
def _51():
    sa(1)
    return 15
def _52():
    sa(9)
    sa(gr(13,1))
    return 53
def _53():
    return (54)if(sp()!=0)else(57)
def _54():
    sa(sr()-1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)

    return (55)if(sp()!=0)else(56)
def _55():
    sa(gr(sr()+4,1))
    return 53
def _56():
    global t0
    t0=2
    sp();
    return 46
def _57():
    sa(sr());
    sa(1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+4)

    sa(1)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(0)
    return 15
def _58():
    sa(sr()-1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    return 47
def _59():
    sp();
    sa(sr());
    sa(0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+4)

    sa(1)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    return 54
def _60():
    sp();
    return 61
def _61():
    sa(sr());
    sa(0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+4)

    sa(2)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sr()-1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)

    return (62)if(sp()!=0)else(40)
def _62():
    sa(gr(sr()+4,2))
    return 63
def _63():
    return (72)if(sp()!=0)else(64)
def _64():
    sa(sr());
    sa(1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+4)

    sa(2)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())

    return (66)if(gr(2,2)!=5)else(65)
def _65():
    sa(1)
    return 17
def _66():
    sa(9)
    sa(gr(13,2))
    return 67
def _67():
    return (68)if(sp()!=0)else(71)
def _68():
    sa(sr()-1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)

    return (69)if(sp()!=0)else(70)
def _69():
    sa(gr(sr()+4,2))
    return 67
def _70():
    global t0
    t0=2
    sp();
    return 61
def _71():
    sa(sr());
    sa(1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+4)

    sa(2)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(0)
    return 17
def _72():
    sa(sr()-1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)

    return (62)if(sp()!=0)else(40)
def _73():
    sp();
    sa(sr());
    sa(0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+4)

    sa(2)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    return 68
def _74():
    global t0
    gw(10,2,0)
    t0=0
    gw(13,2,1)
    sa(-1)
    return 18
def _75():
    gw(10,1,1)
    gw(13,1,0)
    sp();
    return 36
def _76():
    sp();

    return (34)if((gr(4,0)+gr(5,0))!=0)else(77)
def _77():
    gw(10,1,0)
    gw(13,1,1)
    gw(10,2,0)
    gw(13,2,1)
    sa(2)
    return 18
def _78():
    gw(10,2,1)
    gw(13,2,0)
    sp();
    return 37
def _79():
    sa(sp()-1)

    sa(sr());
    sa(sr()%80)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()/80);

    sa(sp()+gr(3,3))

    v0=sp()
    sa(gr(sp(),v0))
    sa(sr()-gr(3,0))
    return 25
def _80():
    sp();
    sp();
    return 28
def _81():
    gw(7,0,gr(sr()+4,2)+(gr(7,0)*2))
    sa(sr()-1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    return 21
def _82():
    gw(6,0,gr(sr()+4,1)+(gr(6,0)*2))
    sa(sr()-1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    return 19
def _83():
    sa(9)
    sa(gr(13,2))
    return 63
def _84():
    sa(9)
    sa(gr(13,1))
    return 49
def _85():
    sa(sr());

    return (90)if((gr(sr()+8,0))!=0)else(86)
def _86():
    sa(sr());
    sa(sr());
    sa(sp()*sp());

    sa(sp()/10);

    gw(2,2,((0)if((gr(sr()+4,2))!=0)else(1))+gr(2,2))
    sa(1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+4)

    sa(2)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sr());
    sa(sp()*sp());

    sa(sp()%10);


    return (89)if(sr()!=9)else(87)
def _87():
    gw(2,1,((0)if((gr(10,1))!=0)else(1))+gr(2,1))
    gw(10,1,1)
    sp();
    return 88
def _88():
    global t0
    t0=6
    sa(sp()-1)

    sa(sr());
    return 5
def _89():
    gw(2,1,((0)if((gr(sr()+4,1))!=0)else(1))+gr(2,1))
    sa(1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+4)

    sa(1)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    return 88
def _90():
    sa(sr());
    sa(sr());
    sa(sp()*sp());

    sa(sp()/10);

    gw(2,1,((0)if((gr(sr()+4,1))!=0)else(1))+gr(2,1))
    sa(1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+4)

    sa(1)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sr());
    sa(sp()*sp());

    sa(sp()%10);


    return (92)if(sr()!=9)else(91)
def _91():
    gw(2,2,((0)if((gr(10,2))!=0)else(1))+gr(2,2))
    gw(10,2,1)
    sp();
    return 88
def _92():
    gw(2,2,((0)if((gr(sr()+4,2))!=0)else(1))+gr(2,2))
    sa(1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+4)

    sa(2)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    return 88
def _93():
    sa(sp()-1)

    sa(sr());
    sa(0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+4)

    sa(1)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sr());
    sa(0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+4)

    sa(2)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sr());
    return 3
def _94():
    sa(sp()-1)

    sa(sr());
    sa(0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+9)

    sa(0)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sr());
    return 1
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14,_15,_16,_17,_18,_19,_20,_21,_22,_23,_24,_25,_26,_27,_28,_29,_30,_31,_32,_33,_34,_35,_36,_37,_38,_39,_40,_41,_42,_43,_44,_45,_46,_47,_48,_49,_50,_51,_52,_53,_54,_55,_56,_57,_58,_59,_60,_61,_62,_63,_64,_65,_66,_67,_68,_69,_70,_71,_72,_73,_74,_75,_76,_77,_78,_79,_80,_81,_82,_83,_84,_85,_86,_87,_88,_89,_90,_91,_92,_93,_94]
c=0
while c<95:
    c=m[c]()
