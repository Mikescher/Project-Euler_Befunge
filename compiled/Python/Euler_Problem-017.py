# compiled with BefunCompile v1.0.2 (c) 2015
# execute with at least Python3
from random import randint
import gzip, base64
_g="AR+LCAAAAAAABACVkEFuwyAQRa8yBmcDcgOGAYoQ6kGQ3UUlb7Ni5dy92E5lEiVWMxvg8/7MhwzvlVAKtVaIWhnjnLWfzplD3hhEtOYIqqp9M8/C505WSoBHKVS3ETWL3ns5EUG6JC90GG9Sv0n9Za74/GIuYz2SHwIC2jb8g39R4dGyNosekZ/7KZXldN/c3/sLqdn3HjiWTGc5WfHHR5Gib2gefblJhRzEJMNiLOdTM1et1zR5z7X1J1fiWFd+qVVO5NVWBiRY7Bs8HD/vtksq2WUup5A8hZHvVALZPff7+ble1dcHH4E2QH0CysMve1WrzNACAAA="
g = base64.b64decode(_g)[1:]
for i in range(base64.b64decode(_g)[0]):
    g = gzip.decompress(g)
def gr(x,y):
    if(x>=0 and y>=0 and x<48 and y<15):
        return g[y*48 + x];
    return 0;
def gw(x,y,v):
    if(x>=0 and y>=0 and x<48 and y<15):
        g[y*48 + x]=v;
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
    return (30)if(sp()!=0)else(11)
def _1():
    return (29)if(sp()!=0)else(12)
def _2():
    return (13)if(sp()!=0)else(20)
def _3():
    return (14)if(sp()!=0)else(15)
def _4():
    return (16)if(sp()!=0)else(17)
def _5():
    return (19)if(sp()!=0)else(18)
def _6():
    return (26)if(sp()!=0)else(21)
def _7():
    return (28)if(sp()!=0)else(27)
def _8():
    return (22)if(sp()!=0)else(25)
def _9():
    return (24)if(sp()!=0)else(23)
def _10():
    gw(20,1,(gr(20,1))-(48))
    sa(20)
    sa(20)
    return 0
def _11():
    gw(20,2,(gr(20,2))-(48))
    sa(20)
    sa(20)
    return 1
def _12():
    sp()
    sp()
    sa(0)
    sa(1000)
    sa(0)
    sa(1000)
    sa(0)
    return 2
def _13():
    sa(sp()+sp());
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr())
    return 3
def _14():
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    return 13
def _15():
    sa(sp()+sp());
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(1)
    v0=sp()
    sa(sp()-v0)
    sa(sr())
    return 4
def _16():
    sa(sr())
    sa(0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr())
    sa((0)if(sp()!=0)else(1))
    return 2
def _17():
    sa(sp()+sp());
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr())
    sa((0)if(sp()!=0)else(1))
    return 5
def _18():
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    return 17
def _19():
    sa(sp()+sp());
    print(sp(),end="",flush=True)
    return 31
def _20():
    sa(sr())
    sa(100)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    v0=sp()
    sa((1)if(sp()>v0)else(0))
    return 6
def _21():
    sa(sr())
    sa(1000)
    v0=sp()
    sa(sp()-v0)
    return 8
def _22():
    sa(sr())
    sa(100)
    v0=sp()
    sa(tm(sp(),v0))
    sa((0)if(sp()!=0)else(1))
    return 9
def _23():
    sa(sr())
    sa(100)
    v0=sp()
    sa(td(sp(),v0))
    sa(1)
    v0=sp()
    sa(gr(sp(),v0))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(100)
    v0=sp()
    sa(tm(sp(),v0))
    sa(7)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(3)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr())
    sa((0)if(sp()!=0)else(1))
    return 2
def _24():
    sa(100)
    v0=sp()
    sa(td(sp(),v0))
    sa(1)
    v0=sp()
    sa(gr(sp(),v0))
    sa(7)
    sa(0)
    sa(1)
    return 2
def _25():
    sp()
    sa(3)
    sa(8)
    sa(0)
    sa(1)
    return 2
def _26():
    sa(sr())
    sa(20)
    v0=sp()
    sa((1)if(sp()>v0)else(0))
    return 7
def _27():
    sa(1)
    v0=sp()
    sa(gr(sp(),v0))
    sa(0)
    sa(1)
    return 2
def _28():
    sa(sr())
    sa(10)
    v0=sp()
    sa(td(sp(),v0))
    sa(2)
    v0=sp()
    sa(gr(sp(),v0))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(10)
    v0=sp()
    sa(tm(sp(),v0))
    sa(sr())
    sa((0)if(sp()!=0)else(1))
    return 2
def _29():
    sa(1)
    v0=sp()
    sa(sp()-v0)
    sa(sr())
    sa(sr())
    sa(sr())
    sa(2)
    v0=sp()
    sa(gr(sp(),v0))
    sa(48)
    v0=sp()
    sa(sp()-v0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(2)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    return 1
def _30():
    sa(1)
    v0=sp()
    sa(sp()-v0)
    sa(sr())
    sa(sr())
    sa(sr())
    sa(1)
    v0=sp()
    sa(gr(sp(),v0))
    sa(48)
    v0=sp()
    sa(sp()-v0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(1)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    return 0
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14,_15,_16,_17,_18,_19,_20,_21,_22,_23,_24,_25,_26,_27,_28,_29,_30]
c=10
while c<31:
    c=m[c]()