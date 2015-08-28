#!/usr/bin/env python3
# compiled with BefunCompile v1.0.7 (c) 2015
import gzip, base64
_g = ("AR+LCAAAAAAABADtlk1r4zAQhv/KRE6hRHgzIztNGYzopfceezBO2N0wUFo6hF2dsv+946Q0DTFNadmc9CALydY7X5LACXvAGkyncLd+flj9+gO3fx9Xayj7+c/H1RPM"
  + "5/At7rd8z8YpinPwf1M4ZyaZTCaTyWQymfNwlj/ICG7lgAkVCDigTmrUUKE6cIxBKWhKWLEnwap5U6Gt6AcY2bRy0Vo3DV7cvSuLtOAKhcnbIk62Kp2Oo4kFaAFsWadd"
  + "5ouuWJpPwbrZlNZbCAcC9WEqSO2FdX1g0Xxv3e7DUZtHezzXKO3yVWnxjbt4EDW4chPHvXqGai8nkUrGdm+r9vpREt37YLjta2chdcdZHqoWqeCBBUnx2v12ivOJ+3fp"
  + "xqer9yHN4Fv8gqWIV6QVSbTaLPttrv2MpJUrEm9fjisUyTORYrCnIo2mtQpL2QbhmpRIlqPJyCzZqCYpeUa6edV2JR3ZG8zmuMx7rMIjO0VzoXAgjGQeLZrdvsZxoD4J"
  + "pk+c1AGfdnZp26SAHwXc7K+uUmU3h6rGLpJXX9tQaHhDjBfnT8AoYw8AAA==")
g = base64.b64decode(_g)[1:]
for i in range(base64.b64decode(_g)[0]):
    g = gzip.decompress(g)
g=list(g)
def gr(x,y):
    if(x>=0 and y>=0 and x<101 and y<39):
        return g[y*101 + x];
    return 0;
def gw(x,y,v):
    if(x>=0 and y>=0 and x<101 and y<39):
        g[y*101 + x]=v;
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
    gw(1,0,101)
    gw(2,0,1)
    gw(4,0,101)
    gw(3,0,2)
    gw(0,2,32)
    gw(1,2,32)
    return 1
def _1():
    gw(tm(gr(3,0),gr(1,0)),(td(gr(3,0),gr(1,0)))+2,88)
    sa(gr(3,0)+gr(3,0))
    sa((1)if((gr(3,0)+gr(3,0))<gr(4,0))else(0))
    return 2
def _2():
    return (27)if(sp()!=0)else(3)
def _3():
    sp()
    return 4
def _4():
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
    sa(sp()+2);
    v0=sp()
    t0=gr(sp(),v0)
    t0=t0-32
    return 5
def _5():
    global t0
    return (6)if((t0)!=0)else(4)
def _6():
    return (1)if(gr(4,0)>gr(3,0))else(7)
def _7():
    gw(3,0,0)
    sa(0)
    sa(gr(0,2)-88)
    return 8
def _8():
    return (9)if(sp()!=0)else(26)
def _9():
    sa(sp()+1);
    return (25)if(sr()!=gr(4,0))else(10)
def _10():
    sp()
    sa(gr(3,0))
    gw(5,0,gr(3,0))
    sa(sp()*gr(1,0));
    return 11
def _11():
    sa(sp()-1);
    sa(sr())
    sa(0)
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
    sa(sp()+4);
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sr())
    return 12
def _12():
    return (11)if(sp()!=0)else(13)
def _13():
    gw(7,0,5000)
    gw(8,0,100)
    gw(1,1,1)
    gw(2,1,0)
    gw(3,1,0)
    sp()
    sa(1)
    return 14
def _14():
    global t0
    global t1
    global t1
    global t1
    global t2
    global t2
    global t2
    t0=gr(3,1)-gr(5,0)
    t1=gr(gr(3,1),2)
    gw(4,1,gr(gr(3,1),2))
    t1=(1)if(t1>gr(1,1))else(0)
    t1=(0)if(t1!=0)else(1)
    t2=t0*t1
    t2=(0)if(t2!=0)else(1)
    return (22)if((t2)!=0)else(15)
def _15():
    global t0
    global t0
    t0=gr(1,1)-gr(4,1)
    gw(5,1,gr(1,1)-gr(4,1))
    return (16)if((t0)!=0)else(21)
def _16():
    gw(6,1,0)
    sa(gr(3,1))
    sa((1)if(gr(3,1)<0)else(0))
    return 17
def _17():
    return (18)if(sp()!=0)else(20)
def _18():
    global t0
    global t1
    global t2
    global t2
    sp()
    t0=gr(2,1)
    t1=gr(6,1)
    gw(gr(1,1),gr(3,1)+4,gr(6,1))
    t2=t0+t1
    gw(2,1,t2)
    return 19
def _19():
    gw(3,1,gr(3,1)+1)
    return 14
def _20():
    global t0
    global t0
    global t0
    sa(sr()+4)
    sa(gr(5,1))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    v0=sp()
    t0=gr(sp(),v0)
    t0=t0+gr(6,1)
    gw(6,1,t0)
    sa(sp()-1);
    sa((1)if(sr()<0)else(0))
    return 17
def _21():
    gw(gr(1,1),gr(3,1)+4,1)
    return 19
def _22():
    return (24)if(gr(2,1)<=gr(7,0))else(23)
def _23():
    print(gr(1,1),end="",flush=True)
    return 28
def _24():
    sa(sp()+1);
    sa(sr())
    gw(1,1,sp())
    gw(2,1,0)
    gw(3,1,0)
    return 14
def _25():
    sa(sr())
    sa(tm(sr(),gr(1,0)))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),gr(1,0)))
    sa(sp()+2);
    v0=sp()
    sa(gr(sp(),v0))
    sa(sp()-88);
    return 8
def _26():
    sa(sr())
    sa(gr(3,0))
    gw(3,0,gr(3,0)+1)
    sa(tm(sr(),gr(1,0)))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),gr(1,0)))
    sa(sp()+2);
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    return 9
def _27():
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
    sa(sp()+2);
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sp()+gr(3,0));
    sa((1)if(sr()<gr(4,0))else(0))
    return 2
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14,_15,_16,_17,_18,_19,_20,_21,_22,_23,_24,_25,_26,_27]
c=0
while c<28:
    c=m[c]()