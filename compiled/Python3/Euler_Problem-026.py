#!/usr/bin/env python3

# transpiled with BefunCompile v1.2.0 (c) 2017
import gzip, base64
_g = ("AR+LCAAAAAAABADtVLsOgzAM/JU0gaWIchYEQVRF/ZAKOlTymikT/fe6MICqqFs7VJyU2HL8uMvgqL4Ps2PHjr/HD1aJ8vqugaAfuju2COjk9AhvCyeqmGATCqoYYDT5"
  + "Yhj2nJrRgr2rEbwjuXCV5Jzwqqmip0ZGWok3CmxtcazlVWIWTIXEmzkxX0xFBR+mtJIOfLos/hRAzpXEICG55RRFIqMWkWM0N0bvSk7IUCkdwziYgHbu2ypvVLb5lGH1"
  + "19os1eYjnvF4IR1ABgAA")
g = base64.b64decode(_g)[1:]
for i in range(base64.b64decode(_g)[0]):
    g = gzip.decompress(g)
g=list(g)
def gr(x,y):
    if(x>=0 and y>=0 and x<100 and y<16):
        return g[y*100 + x];
    return 0;
def gw(x,y,v):
    if(x>=0 and y>=0 and x<100 and y<16):
        g[y*100 + x]=v;
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
    gw(0,0,100)
    gw(6,0,1000)
    gw(8,0,0)
    gw(9,0,0)
    return 1
def _1():
    global t0
    t0=gr(6,0)-1
    gw(6,0,gr(6,0)-1)

    return (3)if((t0)!=0)else(2)
def _2():
    print(gr(8,0),end=" ",flush=True)
    return 11
def _3():
    sa(gr(6,0))
    gw(3,0,gr(6,0))
    sa(sr());
    gw(1,0,sp())
    return 4
def _4():
    global t0
    sa(0)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(tm(sp(),gr(0,0)))

    sa((td(gr(1,0),gr(0,0)))+1)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(gr(1,0)-1)
    t0=gr(1,0)-1
    gw(1,0,gr(1,0)-1)
    return 5
def _5():
    global t0
    return (4)if((t0)!=0)else(6)
def _6():
    gw(4,0,1)
    gw(5,0,0)
    gw(4,0,tm(gr(4,0)*10,gr(3,0)))
    gw(5,0,gr(5,0)+1)
    sp();
    return 7
def _7():
    return (10)if((gr(tm(gr(4,0),gr(0,0)),(td(gr(4,0),gr(0,0)))+1))==0)else(8)
def _8():
    global t0
    t0=gr(5,0)-gr(tm(gr(4,0),gr(0,0)),(td(gr(4,0),gr(0,0)))+1)

    return (9)if((gr(5,0)-gr(tm(gr(4,0),gr(0,0)),(td(gr(4,0),gr(0,0)))+1))>gr(9,0))else(1)
def _9():
    global t0
    gw(9,0,t0)
    gw(8,0,gr(3,0))
    return 1
def _10():
    gw(tm(gr(4,0),gr(0,0)),(td(gr(4,0),gr(0,0)))+1,gr(5,0))
    gw(4,0,tm(gr(4,0)*10,gr(3,0)))
    gw(5,0,gr(5,0)+1)
    return 7
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10]
c=0
while c<11:
    c=m[c]()
