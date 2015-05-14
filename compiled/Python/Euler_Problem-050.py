# compiled with BefunCompile v1.0.5 (c) 2015
# execute with at least Python3
import gzip, base64
_g = ("Ah+LCAAAAAAABACT7+ZgAAEWhre3z+ZddhBhuxBumLer07Pa99/ahI2J5ye5Tg1zMBViSgydIMp/3kJXVHMLb1CLw5zNM458O6Oy+3X+sXsi2/38u8PD59+L3/c3Zs+f"
  + "Tw8/rZL4ejzfLqZOZ1kgA0P9WmWGUTAKRsGQBw/2hzIw/N+zrSbcb9nhxGB387P3289uftEmeHdzYUlqoJnhu1eF23fmV/gs6r6zNff4xFerTsZ/Dnn5Q8d8eenUU9ef"
  + "vsgonqfvp2Raanpz7z3XJTVvlcp3vldnaDj+JtI1fL9d7T67XR6GfoKrv77vv/dW6PdfYYYH6rl8Fx7bWf6fMPNz4fxtq9Xan2/unt1n6cj/7vQDV8tfv05LN+tNK80T"
  + "mzj754p39mk7V766LPL1ZmHeLD21syv8DG8ufsHM8D1z+sRTz11/fnl5svv982vWpt/XxFec//qtkWdflcqL54vWJTAfuL9ubv7m33/8yuLvPPuz+Gvl/dQp1TxvpjIf"
  + "UMzdNWPZjCURMgWXjk/64RXC3uCcNTuT7/zlu7JfrthPsrPQjLvzcvbhb2v6b1jXrv559+DsUvHTDzXkjxVtvWvhb/g+ydDLvPvH0TJR+/k+YQ8ZHzC8y+l8vuVe+P2X"
  + "r/bIuqy7e9oj9L/RzU36j+O/z9m8Ny6hftJx3a4Xn26o+YeeXXR6qf30/3l3857fLrtXHsTwQCHv0888if33zO5zvtn+naP538FdM0J/8iV+S7az11v3+aePHXuD/TLb"
  + "Lzva48LYGequmxvfy89nWMDPAADs11TW6AUAAA==")
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
    gw(1,0,2000)
    gw(2,0,500)
    gw(0,0,1000000)
    gw(3,0,2)
    gw(0,3,32)
    gw(1,3,32)
    return 1
def _1():
    gw(tm(gr(3,0),gr(1,0)),(td(gr(3,0),gr(1,0)))+1,88)
    sa(gr(3,0)+gr(3,0))
    sa((1)if((gr(0,0))>(gr(3,0)+gr(3,0)))else(0))
    return 2
def _2():
    return (31)if(sp()!=0)else(3)
def _3():
    sp()
    return 4
def _4():
    sa(gr(3,0)+1)
    gw(3,0,gr(3,0)+1)
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
    return 5
def _5():
    return (6)if(sp()!=0)else(4)
def _6():
    sa((1)if((gr(0,0))>(gr(3,0)))else(0))
    return (1)if(sp()!=0)else(7)
def _7():
    gw(4,0,0)
    gw(3,0,0)
    return 8
def _8():
    sa(gr(3,0)+1)
    gw(3,0,gr(3,0)+1)
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
    return 9
def _9():
    return (8)if(sp()!=0)else(10)
def _10():
    sa(gr(3,0))
    sa(gr(4,0))
    gw(4,0,gr(4,0)+1)
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
    return (8)if(sp()!=0)else(11)
def _11():
    sa(0)
    sa(gr(4,0)-1)
    gw(4,0,gr(4,0)-1)
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
    return 12
def _12():
    sa(gr(7,0)+1)
    gw(7,0,gr(7,0)+1)
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
    return (13)if(sp()!=0)else(14)
def _13():
    gw(8,0,sp())
    return 12
def _14():
    gw(7,0,gr(7,0)-1)
    sp()
    return 15
def _15():
    sa(gr(8,0))
    gw(5,0,gr(4,0))
    return 16
def _16():
    sa(sr())
    sa(gr(5,0))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(gr(tm(gr(5,0),gr(1,0)),(td(gr(5,0),gr(1,0)))+1))
    v0=sp()
    sa(sp()-v0)
    return (18)if(sp()!=0)else(17)
def _17():
    sp()
    print(sp(),end="",flush=True)
    return 32
def _18():
    return (30)if(sp()!=0)else(19)
def _19():
    sp()
    sa((1)if((0)>(gr(6,0)+gr(9,0)))else(0))
    return (24)if(sp()!=0)else(20)
def _20():
    sa(gr(9,0)-1)
    return (29)if(sp()!=0)else(21)
def _21():
    sa((gr(8,0)-gr(tm(gr(6,0),gr(1,0)),(td(gr(6,0),gr(1,0)))+1))+gr(tm(gr(7,0)+1,gr(1,0)),(td(gr(7,0)+1,gr(1,0)))+1))
    sa((0)if(((1)if((gr(0,0))>((gr(8,0)-gr(tm(gr(6,0),gr(1,0)),(td(gr(6,0),gr(1,0)))+1))+gr(tm(gr(7,0)+1,gr(1,0)),(td(gr(7,0)+1,gr(1,0)))+1)))else(0))!=0)else(1))
    return 22
def _22():
    return (23)if(sp()!=0)else(28)
def _23():
    sp()
    return 24
def _24():
    sa(gr(9,0)-1)
    return (25)if(sp()!=0)else(27)
def _25():
    gw(8,0,gr(8,0)-gr(tm(gr(7,0),gr(1,0)),(td(gr(7,0),gr(1,0)))+1))
    gw(7,0,gr(7,0)-1)
    return 26
def _26():
    gw(9,0,gr(9,0)*-1)
    return 15
def _27():
    gw(8,0,gr(8,0)-gr(tm(gr(6,0),gr(1,0)),(td(gr(6,0),gr(1,0)))+1))
    gw(6,0,gr(6,0)+1)
    return 26
def _28():
    gw(8,0,sp())
    sa(gr(9,0))
    gw(6,0,gr(9,0)+gr(6,0))
    sa(gr(7,0))
    sa(sp()+sp());
    gw(7,0,sp())
    return 15
def _29():
    sa((gr(8,0)+gr(tm(gr(6,0)-1,gr(1,0)),(td(gr(6,0)-1,gr(1,0)))+1))-gr(tm(gr(7,0),gr(1,0)),(td(gr(7,0),gr(1,0)))+1))
    sa((0)if(((1)if((gr(0,0))>((gr(8,0)+gr(tm(gr(6,0)-1,gr(1,0)),(td(gr(6,0)-1,gr(1,0)))+1))-gr(tm(gr(7,0),gr(1,0)),(td(gr(7,0),gr(1,0)))+1)))else(0))!=0)else(1))
    return 22
def _30():
    gw(5,0,gr(5,0)-1)
    return 16
def _31():
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
    return 2
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14,_15,_16,_17,_18,_19,_20,_21,_22,_23,_24,_25,_26,_27,_28,_29,_30,_31]
c=0
while c<32:
    c=m[c]()