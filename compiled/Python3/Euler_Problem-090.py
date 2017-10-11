#!/usr/bin/env python3

# transpiled with BefunCompile v1.2.0 (c) 2017
import gzip, base64
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
for i in range(base64.b64decode(_g)[0]):
    g = gzip.decompress(g)
g=list(g)
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
    return 1
def _1():
    sa(sp()-1);

    sa(sr());
    sa(0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+9);

    sa(0)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sr());
    return 2
def _2():
    return (1)if(sp()!=0)else(3)
def _3():
    gw(2,1,0)
    gw(2,2,0)
    gw(13,1,0)
    gw(13,2,0)
    sp();
    sa(8)
    return 4
def _4():
    sa(sr());
    sa(0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+4);

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
    sa(sp()+4);

    sa(2)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sr());

    return (92)if(sp()!=0)else(5)
def _5():
    sp();
    sa(9)
    return 6
def _6():
    global t0
    sa(sr());
    sa(sr()+8)
    sa(0)
    v0=sp()
    t0=gr(sp(),v0)

    return (89)if((t0)!=0)else(7)
def _7():
    global t0
    sa(sr());
    sa(sr());
    sa(sp()*sp());

    sa(td(sp(),10))

    sa(sr()+4)
    sa(2)
    v0=sp()
    t0=gr(sp(),v0)
    t0=(0)if(t0!=0)else(1)
    t0=t0+gr(2,2)
    gw(2,2,t0)
    sa(1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+4);

    sa(2)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sr());
    sa(sp()*sp());

    sa(tm(sp(),10))


    return (88)if(sr()!=9)else(8)
def _8():
    gw(2,1,((0)if((gr(10,1))!=0)else(1))+gr(2,1))
    gw(10,1,1)
    sp();
    return 9
def _9():
    sa(sp()-1);

    sa(sr());

    return (6)if(sp()!=0)else(10)
def _10():
    sp();

    return (17)if(((1)if(gr(2,1)>6)else(0))+((1)if(gr(2,2)>6)else(0))==0)else(11)
def _11():
    gw(17,0,(0)if((gr(17,0))!=0)else(1))
    sa(8)
    sa(8)
    sa(gr(17,0))
    return 12
def _12():
    return (16)if(sp()!=0)else(13)
def _13():
    sa((0)if(sp()!=0)else(1))

    return (14)if(sp()!=0)else(15)
def _14():
    print(gr(2,0),end=" ",flush=True)
    sp();
    return 93
def _15():
    sa(sp()-1);

    sa(sr());
    sa(sr());
    sa(sr());
    sa(sr()+9)
    sa(0)
    v0=sp()
    sa(gr(sp(),v0))
    sa((0)if(sp()!=0)else(1))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+9);

    sa(0)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sp()+9);

    sa(0)
    v0=sp()
    sa(gr(sp(),v0))
    return 12
def _16():
    sp();
    sp();
    sa(0)
    return 3
def _17():
    return (87)if(6!=gr(2,1))else(18)
def _18():
    sa(2)
    return 19
def _19():
    return (20)if(gr(2,2)!=6)else(86)
def _20():
    sa(9)
    sa(gr(13,2))
    return 21
def _21():
    return (22)if(sp()!=0)else(45)
def _22():
    sa(sr()-1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)

    return (23)if(sp()!=0)else(24)
def _23():
    sa(sr()+4)
    sa(2)
    v0=sp()
    sa(gr(sp(),v0))
    return 21
def _24():
    sp();
    return 25
def _25():
    sa(sr());
    sa((0)if(sp()!=0)else(1))

    return (44)if(sp()!=0)else(26)
def _26():
    sa(sp()-1);

    sa(sr());
    sa((0)if(sp()!=0)else(1))

    return (31)if(sp()!=0)else(27)
def _27():
    sa(sp()-1);

    sa(sr());
    sa((0)if(sp()!=0)else(1))

    return (28)if(sp()!=0)else(30)
def _28():
    gw(17,0,(0)if((gr(17,0))!=0)else(1))
    sp();
    return 29
def _29():
    sa(8)
    sa(8)
    sa(gr(17,0))
    return 12
def _30():
    return 93
def _31():
    sp();
    return 32
def _32():
    sa(sr());
    sa(0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+4);

    sa(1)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sr()-1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    return 33
def _33():
    return (34)if(sp()!=0)else(28)
def _34():
    sa(sr()+4)
    sa(1)
    v0=sp()
    sa(gr(sp(),v0))
    return 35
def _35():
    return (43)if(sp()!=0)else(36)
def _36():
    sa(sr());
    sa(1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+4);

    sa(1)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())

    return (38)if(5!=gr(2,1))else(37)
def _37():
    sa(1)
    return 19
def _38():
    sa(9)
    sa(gr(13,1))
    return 39
def _39():
    return (40)if(sp()!=0)else(42)
def _40():
    sa(sr()-1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)

    return (41)if(sp()!=0)else(31)
def _41():
    sa(sr()+4)
    sa(1)
    v0=sp()
    sa(gr(sp(),v0))
    return 39
def _42():
    sa(sr());
    sa(1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+4);

    sa(1)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(0)
    return 19
def _43():
    sa(sr()-1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    return 33
def _44():
    sp();
    sa(sr());
    sa(0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+4);

    sa(1)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    return 40
def _45():
    sa(sr());
    sa(1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+4);

    sa(2)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())

    return (46)if(5!=gr(2,2))else(85)
def _46():
    sa(9)
    sa(gr(13,2))
    return 47
def _47():
    return (48)if(sp()!=0)else(52)
def _48():
    sa(sr()-1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)

    return (51)if(sp()!=0)else(49)
def _49():
    sp();
    return 50
def _50():
    sa(sr());
    sa(0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+4);

    sa(2)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sr()-1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)

    return (23)if(sp()!=0)else(24)
def _51():
    sa(sr()+4)
    sa(2)
    v0=sp()
    sa(gr(sp(),v0))
    return 47
def _52():
    sa(sr());
    sa(1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+4);

    sa(2)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    gw(4,0,((0)if((gr(10,1))!=0)else(1))+gr(13,1))
    gw(5,0,((0)if((gr(10,2))!=0)else(1))+gr(13,2))
    gw(6,0,0)
    gw(7,0,0)
    gw(6,0,gr(13,1)+(gr(6,0)*2))
    sa(0)
    return 53
def _53():
    sa(0)
    return 54
def _54():
    sa(8)
    return 55
def _55():
    global t0
    sa(sr()+4)
    sa(1)
    v0=sp()
    t0=gr(sp(),v0)
    t0=t0+(gr(6,0)*2)
    gw(6,0,t0)
    sa(sr()-1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    return 56
def _56():
    return (55)if(sp()!=0)else(57)
def _57():
    gw(7,0,gr(13,2)+(gr(7,0)*2))
    sp();
    sa(8)
    return 58
def _58():
    global t0
    sa(sr()+4)
    sa(2)
    v0=sp()
    t0=gr(sp(),v0)
    t0=t0+(gr(7,0)*2)
    gw(7,0,t0)
    sa(sr()-1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    return 59
def _59():
    return (58)if(sp()!=0)else(60)
def _60():
    sp();
    sa(gr(7,0))
    sa(gr(6,0))

    return (61)if(gr(6,0)>gr(7,0))else(62)
def _61():
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    return 62
def _62():
    global t0
    sa(sp()*1024);

    sa(sp()+sp());

    t0=sp()
    gw(3,0,t0)
    sa(1279)
    sa(gr(79,15+gr(3,3)))
    sa(gr(79,15+gr(3,3))-gr(3,0))
    return 63
def _63():
    return (64)if(sp()!=0)else(84)
def _64():
    sa(sp()-35);

    sa((0)if(sp()!=0)else(1))

    return (65)if(sp()!=0)else(83)
def _65():
    sa(gr(3,0))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(tm(sr(),80))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),80))

    sa(sp()+gr(3,3));

    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    gw(2,0,gr(2,0)+1)
    return 66
def _66():
    sa(sp()+1);

    sa(sr());
    sa((0)if(sp()!=0)else(1))

    return (82)if(sp()!=0)else(67)
def _67():
    sa(sp()-1);

    sa(sr());
    sa((0)if(sp()!=0)else(1))

    return (80)if(sp()!=0)else(68)
def _68():
    sa(sp()-1);

    sa(sr());
    sa((0)if(sp()!=0)else(1))

    return (79)if(sp()!=0)else(69)
def _69():
    sa(sp()-1);

    sa(sr());
    sa((0)if(sp()!=0)else(1))

    return (70)if(sp()!=0)else(30)
def _70():
    gw(10,1,1)
    gw(13,1,0)
    gw(10,2,1)
    gw(13,2,0)
    sp();
    return 71
def _71():
    return (72)if((gr(4,0))==0)else(73)
def _72():
    gw(10,1,0)
    gw(13,1,1)
    gw(6,0,0)
    gw(7,0,0)
    gw(6,0,gr(13,1)+(gr(6,0)*2))
    sa(1)
    return 54
def _73():
    return (78)if((gr(5,0))==0)else(74)
def _74():
    sa(sr());
    sa((0)if(sp()!=0)else(1))

    return (77)if(sp()!=0)else(75)
def _75():
    sa(sp()-1);

    sa(sr());
    sa((0)if(sp()!=0)else(1))

    return (49)if(sp()!=0)else(76)
def _76():
    sa(sp()-1);

    sa(sr());
    sa((0)if(sp()!=0)else(1))

    return (24)if(sp()!=0)else(30)
def _77():
    sp();
    sa(sr());
    sa(0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+4);

    sa(2)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    return 48
def _78():
    gw(10,2,0)
    gw(13,2,1)
    gw(6,0,0)
    gw(7,0,0)
    gw(6,0,gr(13,1)+(gr(6,0)*2))
    sa(-1)
    return 54
def _79():
    gw(10,1,1)
    gw(13,1,0)
    sp();
    return 73
def _80():
    sp();

    return (71)if((gr(4,0)+gr(5,0))!=0)else(81)
def _81():
    gw(10,1,0)
    gw(13,1,1)
    gw(10,2,0)
    gw(13,2,1)
    gw(6,0,0)
    gw(7,0,0)
    gw(6,0,gr(13,1)+(gr(6,0)*2))
    sa(2)
    return 54
def _82():
    gw(10,2,1)
    gw(13,2,0)
    sp();
    return 74
def _83():
    sa(sp()-1);

    sa(sr());
    sa(tm(sr(),80))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),80))

    sa(sp()+gr(3,3));

    v0=sp()
    sa(gr(sp(),v0))
    sa(sr()-gr(3,0))
    return 63
def _84():
    sp();
    sp();
    return 66
def _85():
    gw(4,0,((0)if((gr(10,1))!=0)else(1))+gr(13,1))
    gw(5,0,((0)if((gr(10,2))!=0)else(1))+gr(13,2))
    gw(6,0,0)
    gw(7,0,0)
    gw(6,0,gr(13,1)+(gr(6,0)*2))
    sa(1)
    return 53
def _86():
    gw(4,0,((0)if((gr(10,1))!=0)else(1))+gr(13,1))
    gw(5,0,((0)if((gr(10,2))!=0)else(1))+gr(13,2))
    gw(6,0,0)
    gw(7,0,0)
    gw(6,0,gr(13,1)+(gr(6,0)*2))
    sa(2)
    return 53
def _87():
    sa(9)
    sa(gr(13,1))
    return 35
def _88():
    global t0
    sa(sr()+4)
    sa(1)
    v0=sp()
    t0=gr(sp(),v0)
    t0=(0)if(t0!=0)else(1)
    t0=t0+gr(2,1)
    gw(2,1,t0)
    sa(1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+4);

    sa(1)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    return 9
def _89():
    global t0
    sa(sr());
    sa(sr());
    sa(sp()*sp());

    sa(td(sp(),10))

    sa(sr()+4)
    sa(1)
    v0=sp()
    t0=gr(sp(),v0)
    t0=(0)if(t0!=0)else(1)
    t0=t0+gr(2,1)
    gw(2,1,t0)
    sa(1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+4);

    sa(1)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sr());
    sa(sp()*sp());

    sa(tm(sp(),10))


    return (91)if(sr()!=9)else(90)
def _90():
    gw(2,2,((0)if((gr(10,2))!=0)else(1))+gr(2,2))
    gw(10,2,1)
    sp();
    return 9
def _91():
    global t0
    sa(sr()+4)
    sa(2)
    v0=sp()
    t0=gr(sp(),v0)
    t0=(0)if(t0!=0)else(1)
    t0=t0+gr(2,2)
    gw(2,2,t0)
    sa(1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+4);

    sa(2)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    return 9
def _92():
    sa(sp()-1);
    return 4
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14,_15,_16,_17,_18,_19,_20,_21,_22,_23,_24,_25,_26,_27,_28,_29,_30,_31,_32,_33,_34,_35,_36,_37,_38,_39,_40,_41,_42,_43,_44,_45,_46,_47,_48,_49,_50,_51,_52,_53,_54,_55,_56,_57,_58,_59,_60,_61,_62,_63,_64,_65,_66,_67,_68,_69,_70,_71,_72,_73,_74,_75,_76,_77,_78,_79,_80,_81,_82,_83,_84,_85,_86,_87,_88,_89,_90,_91,_92]
c=0
while c<93:
    c=m[c]()
