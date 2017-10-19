#!/usr/bin/env python3

# transpiled with BefunCompile v1.3.0 (c) 2017
import gzip, base64
_g = ("AR+LCAAAAAAABACVjr0OgzAMhF8lUsriiGID4ecURX2QCMasnjLx8A2dWqoO9XLW2b7PxfxRUcCsQhDWntCzDoSBdSSMrJ5Q3paLivBNeQWtygtoUZ5Bs/IEmpR9+Mov"
  + "e7G/6Wgl1EwT4sp5pghwivDeNZxTlQ627NHZkGDD7trjPHKvv4f2fnuYA53zPmVuqsB88CNE8nZ2Wxapo3jFb1fjCcDxR0M7AQAA")
g = base64.b64decode(_g)[1:]
for i in range(base64.b64decode(_g)[0]):
    g = gzip.decompress(g)
g=list(g)
def gr(x,y):
    if(x>=0 and y>=0 and x<45 and y<7):
        return g[y*45 + x];
    return 0;
def gw(x,y,v):
    if(x>=0 and y>=0 and x<45 and y<7):
        g[y*45 + x]=v;
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
    global t0
    gw(0,0,1)
    gw(1,0,1)
    gw(2,0,2)
    gw(3,0,6)
    gw(4,0,24)
    gw(5,0,120)
    gw(6,0,720)
    gw(7,0,5040)
    gw(8,0,40320)
    gw(9,0,362880)
    gw(1,1,0)
    t0=362880
    sa(gr(9,0)*7)
    sa(gr(9,0)*7)
    sa(0)
    sa(gr((gr(9,0)*7)%10,0))
    sa((gr(9,0)*7)/10)
    sa((gr(9,0)*7)/10)
    return 1
def _1():
    return (2)if(sp()!=0)else(3)
def _2():
    sa(gr(sr()%10,0))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()/10);

    sa(sr());

    return (10)if(sp()!=0)else(3)
def _3():
    sa(sp()+sp());

    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr());

    return (9)if(sp()!=0)else(4)
def _4():
    global t0
    global t1
    sa(sp()+sp());

    t0=sp()
    sa(sp()-t0)

    t1=sp()

    return (5)if((t1)!=0)else(8)
def _5():
    sa(sp()-1)

    sa(sr());

    return (6)if(sp()!=0)else(7)
def _6():
    sa(sr());
    sa(sr());
    sa(0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(gr(sr()%10,0))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()/10);

    sa(sr());
    return 1
def _7():
    print(gr(1,1)-3,end=" ",flush=True)
    sa(sr());
    sp();
    sp();
    return 11
def _8():
    gw(1,1,sr()+gr(1,1))
    return 5
def _9():
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    return 3
def _10():
    sa(gr(sr()%10,0))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()/10);

    sa(sr());
    return 1
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10]
c=0
while c<11:
    c=m[c]()
