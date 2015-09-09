#!/usr/bin/env python3
# compiled with BefunCompile v1.0.8 (c) 2015
import gzip, base64
_g = ("AR+LCAAAAAAABACtUE0PwiAM/St0nRcIWhgHtxDiL2EeTLhy4qT/3fqBmy7zYHxJQ9PXPl5bBCIKBv4A8QV/0gump2x6k8ny21EuyxZHqVcdJbuBxPm+5qoUSLCxiTrV"
  + "J3JHKX1gbmhOjQYso1EDK9qdo3yr86yVQZ9XdwrD9FVuLpdDE+OMRd8K9JbS9vDp7+XJyhkTQ3sXNPrJwnK7h0R1J3RcaZkwFoQa/o2pZseIkMkN2vBVfJ4uRHxmpQyA"
  + "llxzXE5kWxapIa6IhbYwMAIAAA==")
g = base64.b64decode(_g)[1:]
for i in range(base64.b64decode(_g)[0]):
    g = gzip.decompress(g)
g=list(g)
def gr(x,y):
    if(x>=0 and y>=0 and x<80 and y<7):
        return g[y*80 + x];
    return 0;
def gw(x,y,v):
    if(x>=0 and y>=0 and x<80 and y<7):
        g[y*80 + x]=v;
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
    gw(9,0,1)
    gw(9,1,1)
    gw(2,0,0)
    gw(3,0,1)
    return 1
def _1():
    sa(gr(3,0))
    return (2)if(gr(3,0)-100==0)else(3)
def _2():
    print(gr(2,0),end="",flush=True)
    sp()
    return 16
def _3():
    sa(sp()+1);
    sa(sr())
    gw(3,0,sp())
    sa(td(sp(),2))
    gw(4,0,sp())
    sa(gr(3,0)-(gr(4,0)*2))
    return 4
def _4():
    return (15)if(sp()!=0)else(5)
def _5():
    sa(gr(gr(4,0)+8,(0)if(tm(gr(3,0),2)!=0)else(1))*2)
    gw(gr(4,0)+9,tm(gr(3,0),2),gr(gr(4,0)+8,(0)if(tm(gr(3,0),2)!=0)else(1))*2)
    return 6
def _6():
    global t0
    sa((1)if(sp()>1000000)else(0))
    t0=(0)if((gr(gr(4,0)+9,(0)if(tm(gr(3,0),2)!=0)else(1)))!=0)else(1)
    return (7)if(((1)if((gr(gr(4,0)+8,(0)if(tm(gr(3,0),2)!=0)else(1)))!=0)else(0))!=0)else(13)
def _7():
    global t0
    t0=(0)if(t0!=0)else(1)
    return (8)if((t0)!=0)else(13)
def _8():
    sa((0)if(sp()!=0)else(1))
    return (9)if(sp()!=0)else(11)
def _9():
    global t0
    t0=gr(4,0)-1
    gw(4,0,gr(4,0)-1)
    t0=(0)if(t0!=0)else(1)
    return (1)if((t0)!=0)else(10)
def _10():
    sa(sp()-(gr(3,0)-(gr(4,0)*2)));
    return 4
def _11():
    gw(2,0,gr(2,0)+((1)if(gr(3,0)-(gr(4,0)*2)!=0)else(0))+1)
    gw(gr(4,0)+9,tm(gr(3,0),2),0)
    return 12
def _12():
    sp()
    return 9
def _13():
    gw(2,0,gr(2,0)+((1)if(gr(3,0)-(gr(4,0)*2)!=0)else(0))+1)
    gw(gr(4,0)+9,tm(gr(3,0),2),0)
    return 14
def _14():
    sp()
    return 12
def _15():
    sa(gr(gr(4,0)+9,(0)if(tm(gr(3,0),2)!=0)else(1))+gr(gr(4,0)+8,(0)if(tm(gr(3,0),2)!=0)else(1)))
    gw(gr(4,0)+9,tm(gr(3,0),2),gr(gr(4,0)+9,(0)if(tm(gr(3,0),2)!=0)else(1))+gr(gr(4,0)+8,(0)if(tm(gr(3,0),2)!=0)else(1)))
    return 6
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14,_15]
c=0
while c<16:
    c=m[c]()