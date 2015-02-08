# compiled with BefunCompile v1.0.4 (c) 2015
# execute with at least Python3
import gzip, base64
_g = ("Ah+LCAAAAAAABACT7+ZgAAEWhre3DuZddhBguBBfKPt9ksnZXWpdSVNFxd/JVG+YxLVCZ6HSGq6aV8c36/Gqdjg4tK54ZHvy2jrjbPXlJ9csP79v1tlN4eby92L3/pyx"
  + "909Jbelk3/afr1+v/h659QTY+Ia5bgyjYBSMgiEPDtRrMzPM2zNj/9n5Z48/3sVz16b3+NfIF8cUS9JDX3zSWe98dWrodf6NtRFnVm/eEHmrNdXC/o45O4PZr7+Hyp68"
  + "/ZpVcrNtFa+QNYNMwBn9T1pbVtrk988umRU6We9sspVaKUducaW8xavrRwu2zrmysui/2T7f1D9fvk2wZ2LoOH3h2fnNf548+XL02a1Vs0M2m005W2h19eyGj/O0Plx9"
  + "N3vFecYHBd/u5O//3F+0bT8bw4fj24yq71z9Mc9O419QcI39qWVLU/gY+pd5uN/ZX9bv+tngZvbNSrHXv0rs5s/RcbaObHtXbsbF0KC70U7q62vXF9MMV4sv9JUsq7nP"
  + "UT7b6F3Y7duudrJrr5XOTZp1ekuWxJlTancTt8q1nd2w42X9ljXx5l9tSo5/3q1+ZtYvs7rrjuKzI6Yf/ts9f89SdoayzqPTy3aEaOZbPWqb86t77fsImx731YurjP88"
  + "3BQh8jCx6HvLDlnFbuYDkzdpdR+qLmKosJnPeCvsc9KC9fwMAD1IlPqhBQAA")
g = base64.b64decode(_g)[1:]
for i in range(base64.b64decode(_g)[0]):
    g = gzip.decompress(g)
g=list(g)
def gr(x,y):
    if(x>=0 and y>=0 and x<2000 and y<514):
        return g[y*2000 + x];
    return 0;
def gw(x,y,v):
    if(x>=0 and y>=0 and x<2000 and y<514):
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
    return (8)if(sp()!=0)else(9)
def _1():
    return (24)if(sp()!=0)else(10)
def _2():
    return (23)if(sp()!=0)else(12)
def _3():
    return (25)if(sp()!=0)else(13)
def _4():
    return (19)if(sp()!=0)else(18)
def _5():
    return (20)if(sp()!=0)else(22)
def _6():
    gw(1,0,2000)
    gw(2,0,500)
    gw(0,0,1000000)
    gw(3,0,2)
    gw(0,3,32)
    gw(1,3,32)
    return 7
def _7():
    gw(tm(gr(3,0),gr(1,0)),(td(gr(3,0),gr(1,0)))+(3),88)
    sa((gr(3,0))+(gr(3,0)))
    sa((1)if((gr(0,0))>((gr(3,0))+(gr(3,0))))else(0))
    return 0
def _8():
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
    sa(3)
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
def _9():
    sp()
    return 10
def _10():
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
    sa(3)
    sa(sp()+sp());
    v0=sp()
    sa(gr(sp(),v0))
    sa(32)
    v0=sp()
    sa(sp()-v0)
    return 1
def _11():
    gw(9,0,0)
    sa(0)
    sa(2)
    sa(3)
    sa(5)
    sa(7)
    sa(0)
    return 2
def _12():
    gw(7,0,sp())
    sa(9)
    sa((9)+((gr(7,0))*(10)))
    sa((1)if((gr(0,0))>((9)+((gr(7,0))*(10))))else(0))
    return 3
def _13():
    sp()
    return 30
def _14():
    sa(1)
    v0=sp()
    sa(sp()-v0)
    sa(sr())
    sa((gr(7,0))*(10))
    sa(sp()+sp());
    sa(sr())
    sa(gr(0,0))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    v0=sp()
    sa((1)if(sp()>v0)else(0))
    return 3
def _15():
    sp()
    sa(sr())
    sa((0)if(sp()!=0)else(1))
    return 2
def _16():
    sp()
    sa((0)if(sp()!=0)else(1))
    sa(sr())
    return 17
def _17():
    sp()
    sp()
    sa(0)
    return 4
def _18():
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    return 30
def _19():
    sa(sr())
    sa(sr())
    print(sp(),end="",flush=True)
    print(chr(10),end="",flush=True)
    sa(gr(9,0))
    sa(sp()+sp());
    gw(9,0,sp())
    return 18
def _20():
    sp()
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    return 28
def _21():
    sp()
    sp()
    sa(1)
    return 4
def _22():
    sa(10)
    v0=sp()
    sa(td(sp(),v0))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(10)
    sa(sp()*sp());
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr())
    sa((0)if(sp()!=0)else(1))
    return 5
def _23():
    sp()
    sa(61)
    print(chr(32),end="",flush=True)
    print(chr(sp()),end="",flush=True)
    print(gr(9,0),end="",flush=True)
    return 31
def _24():
    sa((1)if((gr(0,0))>(gr(3,0)))else(0))
    return (7)if(sp()!=0)else(11)
def _25():
    sa(sr())
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
    sa(3)
    sa(sp()+sp());
    v0=sp()
    sa(gr(sp(),v0))
    sa(88)
    v0=sp()
    sa(sp()-v0)
    return (13)if(sp()!=0)else(26)
def _26():
    sa(sr())
    sa(sr())
    sa(10)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    v0=sp()
    sa((1)if(sp()>v0)else(0))
    return (16)if(sp()!=0)else(27)
def _27():
    sa(sr())
    sa(10)
    v0=sp()
    sa(td(sp(),v0))
    sa(1)
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr())
    sa((0)if(sp()!=0)else(1))
    return (20)if(sp()!=0)else(22)
def _28():
    sa(sr())
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
    sa(3)
    sa(sp()+sp());
    v0=sp()
    sa(gr(sp(),v0))
    sa(88)
    v0=sp()
    sa(sp()-v0)
    return (17)if(sp()!=0)else(29)
def _29():
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr())
    gw(5,0,sp())
    v0=sp()
    sa(tm(sp(),v0))
    sa(td(gr(5,0),10))
    v0=sp()
    v1=sp()
    sa(v0)
    sa(v1)
    sa(sr())
    return (28)if(sp()!=0)else(21)
def _30():
    sa(sr())
    sa(1)
    v0=sp()
    sa(sp()-v0)
    return (14)if(sp()!=0)else(15)
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14,_15,_16,_17,_18,_19,_20,_21,_22,_23,_24,_25,_26,_27,_28,_29,_30]
c=6
while c<31:
    c=m[c]()