# compiled with BefunCompile v1.0.3 (c) 2015
# execute with at least Python3
from random import randint
import gzip, base64
_g="Ah+LCAAAAAAABACT7+ZgAAEWhre3z+ZddhBhuxBumLer07Pa99/ahI2J5ye5Tg1zMBViSgydIMp/3kJXVHMLb1CLw5zNM458O6Oy+3X+sXsi2/38u8PD59+L3/c3Zs+fTw8/rZL4ejzfLqZOZ1kgA0P9WmWGUTAKRsGQBw/2hzIw/N+zrSbcb9nhxGB387P3289uftEmeHdzYUlqoJnhu1eF23fmV/gs6r6zNff4xFerTsZ/Dnn5Q8d8eenUU9efvsgonqfvp2Raanpz7z3XJTVvlcp3vldnaDj+JtI1fL9d7T67XR6GfoKrv77vv/dW6PdfYYYH6rl8Fx7bWf6fMPNz4fxtq9Xan2/unt1n6cj/7vQDV8tfv05LN+tNK80Tmzj754p39mk7V766LPL1ZmHeLD21syv8DG8ufsHM8D1z+sRTz11/fnl5svv982vWpt/XxFec//qtkWdflcqL54vWJTAfuL9ubv7m33/8yuLvPPuz+Gvl/dQp1TxvpjIfUMzdNWPZjCURMgWXjk/64RXC3uCcNTuT7/zlu7JfrthPsrPQjLvzcvbhb2v6b1jXrv559+DsUvHTDzXkjxVtvWvhb/g+ydDLvPvH0TJR+/k+YQ8ZHzC8y+l8vuVe+P2Xr/bIuqy7e9oj9L/RzU36j+O/z9m8Ny6hftJx3a4Xn26o+YeeXXR6qf30/3l3857fLrtXHsTwQCHv0888if33zO5zvtn+naP538FdM0J/8iV+S7az11v3+aePHXuD/TLbLzva48LYGequmxvfy89nWMDPAADs11TW6AUAAA=="
g = base64.b64decode(_g)[1:]
for i in range(base64.b64decode(_g)[0]):
    g = gzip.decompress(g)
g=list(g)
def gr(x,y):
    if(x>=0 and y>=0 and x<2000 and y<512):
        return g[y*2000 + x];
    return 0;
def gw(x,y,v):
    if(x>=0 and y>=0 and x<2000 and y<512):
        g[y*2000 + x]=v;
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
    return (14)if(sp()!=0)else(15)
def _1():
    return (17)if(sp()!=0)else(16)
def _2():
    return (13)if(sp()!=0)else(18)
def _3():
    return (19)if(sp()!=0)else(20)
def _4():
    return (19)if(sp()!=0)else(21)
def _5():
    return (38)if(sp()!=0)else(23)
def _6():
    return (7)if(sp()!=0)else(37)
def _7():
    return (26)if(sp()!=0)else(27)
def _8():
    return (32)if(sp()!=0)else(28)
def _9():
    return (35)if(sp()!=0)else(33)
def _10():
    return (29)if(sp()!=0)else(36)
def _11():
    return (31)if(sp()!=0)else(30)
def _12():
    gw(1,0,2000)
    gw(2,0,500)
    gw(0,0,1000000)
    gw(3,0,2)
    gw(0,3,32)
    gw(1,3,32)
    return 13
def _13():
    gw(tm(gr(3,0),gr(1,0)),(td(gr(3,0),gr(1,0)))+(1),88)
    sa((gr(3,0))+(gr(3,0)))
    sa((1)if((gr(0,0))>((gr(3,0))+(gr(3,0))))else(0))
    return 0
def _14():
    sa(sr())
    sa(32)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr())
    sa(gr(1,0))
    v0=sp()
    sa(tm(sp(),v0))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(gr(1,0))
    v0=sp()
    sa(td(sp(),v0))
    sa(1)
    sa(sp()+sp());
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(gr(3,0))
    sa(sp()+sp());
    sa(sr())
    sa(gr(0,0))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    v0=sp()
    sa((1)if(sp()>v0)else(0))
    return 0
def _15():
    sp()
    return 16
def _16():
    sa((gr(3,0))+(1))
    gw(3,0,(gr(3,0))+(1))
    sa(sr())
    sa(gr(1,0))
    v0=sp()
    sa(tm(sp(),v0))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(gr(1,0))
    v0=sp()
    sa(td(sp(),v0))
    sa(1)
    sa(sp()+sp());
    v0=sp()
    sa(gr(sp(),v0))
    sa(32)
    v0=sp()
    sa(sp()-v0)
    return 1
def _17():
    sa((1)if((gr(0,0))>(gr(3,0)))else(0))
    return 2
def _18():
    gw(4,0,0)
    gw(3,0,0)
    return 19
def _19():
    sa((gr(3,0))+(1))
    gw(3,0,(gr(3,0))+(1))
    sa(sr())
    sa(gr(1,0))
    v0=sp()
    sa(tm(sp(),v0))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(gr(1,0))
    v0=sp()
    sa(td(sp(),v0))
    sa(1)
    sa(sp()+sp());
    v0=sp()
    sa(gr(sp(),v0))
    sa(88)
    v0=sp()
    sa(sp()-v0)
    return 3
def _20():
    sa(gr(3,0))
    sa(gr(4,0))
    gw(4,0,(gr(4,0))+(1))
    sa(sr())
    sa(gr(1,0))
    v0=sp()
    sa(tm(sp(),v0))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(gr(1,0))
    v0=sp()
    sa(td(sp(),v0))
    sa(1)
    sa(sp()+sp());
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa((1)if((gr(0,0))>(gr(3,0)))else(0))
    return 4
def _21():
    sa(0)
    sa((gr(4,0))-(1))
    gw(4,0,(gr(4,0))-(1))
    sa(sr())
    sa(gr(1,0))
    v0=sp()
    sa(tm(sp(),v0))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(gr(1,0))
    v0=sp()
    sa(td(sp(),v0))
    sa(1)
    sa(sp()+sp());
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    gw(6,0,0)
    gw(7,0,-1)
    gw(8,0,0)
    gw(9,0,1)
    return 22
def _22():
    sa((gr(7,0))+(1))
    gw(7,0,(gr(7,0))+(1))
    sa(sr())
    sa(gr(1,0))
    v0=sp()
    sa(tm(sp(),v0))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(gr(1,0))
    v0=sp()
    sa(td(sp(),v0))
    sa(1)
    sa(sp()+sp());
    v0=sp()
    sa(gr(sp(),v0))
    sa(gr(8,0))
    sa(sp()+sp());
    sa(sr())
    sa(gr(0,0))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    v0=sp()
    sa((1)if(sp()>v0)else(0))
    return 5
def _23():
    gw(7,0,(gr(7,0))-(1))
    sp()
    return 24
def _24():
    sa(gr(8,0))
    gw(5,0,gr(4,0))
    return 25
def _25():
    sa(sr())
    sa(gr(5,0))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(gr(tm(gr(5,0),gr(1,0)),(td(gr(5,0),gr(1,0)))+(1)))
    v0=sp()
    sa(sp()-v0)
    return 6
def _26():
    gw(5,0,(gr(5,0))-(1))
    return 25
def _27():
    sp()
    sa((1)if((0)>((gr(6,0))+(gr(9,0))))else(0))
    return 8
def _28():
    sa((gr(9,0))-(1))
    return 10
def _29():
    sa(((gr(8,0))+(gr(tm((gr(6,0))-(1),gr(1,0)),(td((gr(6,0))-(1),gr(1,0)))+(1))))-(gr(tm(gr(7,0),gr(1,0)),(td(gr(7,0),gr(1,0)))+(1))))
    sa((0)if(((1)if((gr(0,0))>(((gr(8,0))+(gr(tm((gr(6,0))-(1),gr(1,0)),(td((gr(6,0))-(1),gr(1,0)))+(1))))-(gr(tm(gr(7,0),gr(1,0)),(td(gr(7,0),gr(1,0)))+(1)))))else(0))!=0)else(1))
    return 11
def _30():
    gw(8,0,sp())
    sa(gr(9,0))
    gw(6,0,(gr(9,0))+(gr(6,0)))
    sa(gr(7,0))
    sa(sp()+sp());
    gw(7,0,sp())
    return 24
def _31():
    sp()
    return 32
def _32():
    sa((gr(9,0))-(1))
    return 9
def _33():
    gw(8,0,(gr(8,0))-(gr(tm(gr(6,0),gr(1,0)),(td(gr(6,0),gr(1,0)))+(1))))
    gw(6,0,(gr(6,0))+(1))
    return 34
def _34():
    gw(9,0,(gr(9,0))*(-1))
    return 24
def _35():
    gw(8,0,(gr(8,0))-(gr(tm(gr(7,0),gr(1,0)),(td(gr(7,0),gr(1,0)))+(1))))
    gw(7,0,(gr(7,0))-(1))
    return 34
def _36():
    sa(((gr(8,0))-(gr(tm(gr(6,0),gr(1,0)),(td(gr(6,0),gr(1,0)))+(1))))+(gr(tm((gr(7,0))+(1),gr(1,0)),(td((gr(7,0))+(1),gr(1,0)))+(1))))
    sa((0)if(((1)if((gr(0,0))>(((gr(8,0))-(gr(tm(gr(6,0),gr(1,0)),(td(gr(6,0),gr(1,0)))+(1))))+(gr(tm((gr(7,0))+(1),gr(1,0)),(td((gr(7,0))+(1),gr(1,0)))+(1)))))else(0))!=0)else(1))
    return 11
def _37():
    sp()
    print(sp(),end="",flush=True)
    return 39
def _38():
    gw(8,0,sp())
    return 22
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14,_15,_16,_17,_18,_19,_20,_21,_22,_23,_24,_25,_26,_27,_28,_29,_30,_31,_32,_33,_34,_35,_36,_37,_38]
c=12
while c<39:
    c=m[c]()