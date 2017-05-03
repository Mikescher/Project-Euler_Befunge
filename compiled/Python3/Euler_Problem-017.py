#!/usr/bin/env python3

# transpiled with BefunCompile v1.1.0 (c) 2015
import gzip, base64
_g = ("AR+LCAAAAAAABACVkEFuwyAQRa8yBmcDcgOGAYoQ6kGQ3UUlb7Ni5dy92E5lEiVWMxvg8/7MhwzvlVAKtVaIWhnjnLWfzplD3hhEtOYIqqp9M8/C505WSoBHKVS3ETWL"
  + "3ns5EUG6JC90GG9Sv0n9Za74/GIuYz2SHwIC2jb8g39R4dGyNosekZ/7KZXldN/c3/sLqdn3HjiWTGc5WfHHR5Gib2gefblJhRzEJMNiLOdTM1et1zR5z7X1J1fiWFd+"
  + "qVVO5NVWBiRY7Bs8HD/vtksq2WUup5A8hZHvVALZPff7+ble1dcHH4E2QH0CysMve1WrzNACAAA=")
g = base64.b64decode(_g)[1:]
for i in range(base64.b64decode(_g)[0]):
    g = gzip.decompress(g)
g=list(g)
def gr(x,y):
    if(x>=0 and y>=0 and x<48 and y<15):
        return g[y*48 + x];
    return 0;
def gw(x,y,v):
    if(x>=0 and y>=0 and x<48 and y<15):
        g[y*48 + x]=v;
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
    gw(20,1,gr(20,1)-48)
    sa(19)
    return 1
def _1():
    sa(sr());
    sa(sr());
    sa(sr());
    sa(1)
    v0=sp()
    sa(gr(sp(),v0))
    sa(sp()-48);

    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(1)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())

    return (24)if(sp()!=0)else(2)
def _2():
    gw(20,2,gr(20,2)-48)
    sa(19)
    return 3
def _3():
    sa(sr());
    sa(sr());
    sa(sr());
    sa(2)
    v0=sp()
    sa(gr(sp(),v0))
    sa(sp()-48);

    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(2)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())

    return (23)if(sp()!=0)else(4)
def _4():
    sp();
    sp();
    sa(0)
    sa(1000)
    sa(0)
    sa(1000)
    return 5
def _5():
    return (6)if(sr()<100)else(18)
def _6():
    return (17)if(sr()>20)else(7)
def _7():
    sa(1)
    v0=sp()
    sa(gr(sp(),v0))
    sa(sp()+0);
    return 8
def _8():
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr());

    return (16)if(sp()!=0)else(9)
def _9():
    sa(sp()+sp());

    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()-1);

    sa(sr());

    return (13)if(sp()!=0)else(10)
def _10():
    sa(sp()+sp());

    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr());
    sa((0)if(sp()!=0)else(1))

    return (12)if(sp()!=0)else(11)
def _11():
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    return 10
def _12():
    global t0
    sa(sp()+sp());

    t0=sp()
    print(t0,end="",flush=True)
    return 25
def _13():
    sa(sr());
    sa(0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr());
    sa((0)if(sp()!=0)else(1))
    return 14
def _14():
    return (15)if(sp()!=0)else(5)
def _15():
    sa(sp()+sp());
    return 8
def _16():
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()+sp());
    return 8
def _17():
    sa(td(sr(),10))
    sa(2)
    v0=sp()
    sa(gr(sp(),v0))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(tm(sp(),10))

    sa(sr());
    sa((0)if(sp()!=0)else(1))
    return 14
def _18():
    return (20)if(sr()!=1000)else(19)
def _19():
    sp();
    sa(3)
    sa(8)
    return 8
def _20():
    return (22)if(tm(sr(),100)==0)else(21)
def _21():
    sa(td(sr(),100))
    sa(1)
    v0=sp()
    sa(gr(sp(),v0))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(tm(sp(),100))

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
    sa(sr());
    sa((0)if(sp()!=0)else(1))
    return 14
def _22():
    sa(td(sp(),100))

    sa(1)
    v0=sp()
    sa(gr(sp(),v0))
    sa(7)
    return 8
def _23():
    sa(sp()-1);
    return 3
def _24():
    sa(sp()-1);
    return 1
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14,_15,_16,_17,_18,_19,_20,_21,_22,_23,_24]
c=0
while c<25:
    c=m[c]()
