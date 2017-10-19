#!/usr/bin/env python2

# transpiled with BefunCompile v1.3.0 (c) 2017
import sys
import zlib, base64
_g = ("Ah+LCAAAAAAABACT7+ZgAAEWhre3DuZddhBguBBfKPt9ksnZXWpdSVNFxd/JVG+YxLVCZ6HSGq6aV8c36/Gqdjg4tK54ZHvy2jrjbPXlJ9csP79v1tlN4eby92L3/pyx"
  + "909Jbelk3/afr1+v/h659QTY+Ia5bgyjYBSMgiEPDtRrMzPM2zNj/9n5Z48/3sVz16b3+NfIF8cUS9JDX3zSWe98dWrodf6NtRFnVm/eEHmrNdXC/o45O4PZr7+Hyp68"
  + "/ZpVcrNtFa+QNYNMwBn9T1pbVtrk988umRU6We9sspVaKUducaW8xavrRwu2zrmysui/2T7f1D9fvk2wZ2LoOH3h2fnNf548+XL02a1Vs0M2m005W2h19eyGj/O0Plx9"
  + "N3vFecYHBd/u5O//3F+0bT8bw4fj24yq71z9Mc9O419QcI39qWVLU/gY+pd5uN/ZX9bv+tngZvbNSrHXv0rs5s/RcbaObHtXbsbF0KC70U7q62vXF9MMV4sv9JUsq7nP"
  + "UT7b6F3Y7duudrJrr5XOTZp1ekuWxJlTancTt8q1nd2w42X9ljXx5l9tSo5/3q1+ZtYvs7rrjuKzI6Yf/ts9f89SdoayzqPTy3aEaOZbPWqb86t77fsImx731YurjP88"
  + "3BQh8jCx6HvLDlnFbuYDkzdpdR+qLmKosJnPeCvsc9KC9fwMAD1IlPqhBQAA")
g = base64.b64decode(_g)[1:]
for i in range(ord(base64.b64decode(_g)[0])):
    g = zlib.decompress(g, 16+zlib.MAX_WBITS)
g=list(map(ord, g))
def gr(x,y):
    if(x>=0 and y>=0 and x<2000 and y<514):
        return g[y*2000 + x];
    return 0;
def gw(x,y,v):
    if(x>=0 and y>=0 and x<2000 and y<514):
        g[y*2000 + x]=v;
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
    gw(tm(gr(3,0),gr(1,0)),(td(gr(3,0),gr(1,0)))+3,88)
    sa(gr(3,0)+gr(3,0))
    sa((1)if((gr(3,0)+gr(3,0))<gr(0,0))else(0))
    return 2
def _2():
    return (29)if(sp()!=0)else(3)
def _3():
    sp();
    return 4
def _4():
    global t0
    sa(gr(3,0)+1)
    sa(gr(3,0)+1)
    gw(3,0,gr(3,0)+1)
    sa(tm(sp(),gr(1,0)))

    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),gr(1,0)))

    sa(sp()+3)

    v0=sp()
    t0=gr(sp(),v0)
    t0=t0-32
    return 5
def _5():
    global t0
    return (6)if((t0)!=0)else(4)
def _6():
    return (1)if(gr(0,0)>gr(3,0))else(7)
def _7():
    global t0
    gw(9,0,0)
    t0=0
    sa(0)
    sa(2)
    sa(3)
    sa(5)
    sa(7)
    sa(7)
    return 8
def _8():
    return (10)if(sp()!=0)else(9)
def _9():
    sys.stdout.write(" =")
    sys.stdout.flush()

    sys.stdout.write(str(gr(9,0))+" ")
    sys.stdout.flush()

    sp();
    return 30
def _10():
    gw(7,0,sp())
    sa(9)
    sa(9+(gr(7,0)*10))
    sa((1)if((9+(gr(7,0)*10))<gr(0,0))else(0))
    return 11
def _11():
    return (12)if(sp()!=0)else(28)
def _12():
    global t0
    sa(sr());
    sa(tm(sr(),gr(1,0)))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),gr(1,0)))

    sa(sp()+3)

    v0=sp()
    t0=gr(sp(),v0)
    t0=t0-88

    return (27)if((t0)!=0)else(13)
def _13():
    sa(sr());

    return (14)if(sr()<10)else(20)
def _14():
    sp();
    sa((0)if(sp()!=0)else(1))
    sa(sr());
    return 15
def _15():
    sp();
    sp();
    return 16
def _16():
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    return 17
def _17():
    return (19)if(sr()!=1)else(18)
def _18():
    sp();
    sa(sr());
    return 8
def _19():
    sa(sp()-1)

    sa(sr()+(gr(7,0)*10))
    sa((1)if(sr()<gr(0,0))else(0))
    return 11
def _20():
    sa(sr()/10)
    sa(1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr());
    return 21
def _21():
    return (22)if(sp()!=0)else(23)
def _22():
    sa(sp()/10);

    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sp()*10)

    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr());
    return 21
def _23():
    sp();
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    return 24
def _24():
    global t0
    sa(sr());
    sa(tm(sr(),gr(1,0)))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(td(sp(),gr(1,0)))

    sa(sp()+3)

    v0=sp()
    t0=gr(sp(),v0)
    t0=t0-88

    return (15)if((t0)!=0)else(25)
def _25():
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr());
    gw(5,0,sp())
    v0=sp()
    sa(tm(sp(),v0))

    sa(gr(5,0)/10)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr());

    return (24)if(sp()!=0)else(26)
def _26():
    sp();
    sp();
    sa(sr());
    sa(sr());
    sys.stdout.write(str(sp())+" ")
    sys.stdout.flush()

    sys.stdout.write(chr(10))
    sys.stdout.flush()

    sa(sp()+gr(9,0))

    gw(9,0,sp())
    return 16
def _27():
    sp();
    return 17
def _28():
    global t0
    t0=0
    return 27
def _29():
    sa(sr());
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

    sa(sp()+3)

    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    sa(sp()+gr(3,0))

    sa((1)if(sr()<gr(0,0))else(0))
    return 2
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14,_15,_16,_17,_18,_19,_20,_21,_22,_23,_24,_25,_26,_27,_28,_29]
c=0
while c<30:
    c=m[c]()
