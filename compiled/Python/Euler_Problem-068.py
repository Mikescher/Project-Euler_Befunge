#!/usr/bin/env python3
# compiled with BefunCompile v1.0.7 (c) 2015
import gzip, base64
_g = ("AR+LCAAAAAAABAClks1yhCAMx18FcG8MFvxYjeMwfYO97qGj3rhy4rQPvwkq2g720GYGiJL880s0MPZktIpk7Moo8JEsF2HFIAKe4VKDsZGNIR4Y5o0EJbRwWoLX9aCM"
  + "07V4iDXOgsaX2ttaO5DaGTWsnscUNXR4+7W8YjFMm6eCpyIKRRyKO93F52K82aEIc6ddu/wCZ19BmZEk51DwBWXhlm0iqkUXJUHxXBCbWFRbJ/MUFCmNxxlhG0ZiM56a"
  + "mfA2qoHGJsHQVuEmZWv8SX1TszFCfAjFoE8e7F7Y1ACfcUqYn+93UwsKs3D8HbDNuyevB/pKGxsRQU1bs7E5xfmKJw+2eyJqktf+k61ORFXymjMblYpVYvlLtioRHRPU"
  + "f2Q77JOVZflz7WwRCDra+gwaqfUwZgt9N0sSsP8fu84JlsdO3+lgHQ7PAwAA")
g = base64.b64decode(_g)[1:]
for i in range(base64.b64decode(_g)[0]):
    g = gzip.decompress(g)
g=list(g)
def gr(x,y):
    if(x>=0 and y>=0 and x<39 and y<25):
        return g[y*39 + x];
    return 0;
def gw(x,y,v):
    if(x>=0 and y>=0 and x<39 and y<25):
        g[y*39 + x]=v;
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
    gw(9,0,58)
    gw(3,0,0)
    return 1
def _1():
    sa(gr(gr(3,0)+9,0)-1)
    gw(gr(3,0)+9,0,gr(gr(3,0)+9,0)-1)
    sa(sp()-48);
    sa(sr())
    gw(7,0,sp())
    sa((1)if(sp()<0)else(0))
    return (2)if(sp()!=0)else(3)
def _2():
    sa(79)
    sa(gr(3,0)-1)
    gw(3,0,gr(3,0)-1)
    sa(sp()+9);
    sa(0)
    v0=sp()
    sa(gr(sp(),v0))
    sa(sp()-48);
    sa(sp()+9);
    sa(1)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    return 1
def _3():
    return (4)if(gr(gr(7,0)+9,1)-79==0)else(1)
def _4():
    sa(gr(3,0))
    return (5)if((gr(3,0))!=0)else(25)
def _5():
    sa(sp()-1);
    sa(sr())
    return (6)if(sp()!=0)else(24)
def _6():
    sa(sp()-1);
    sa(sr())
    return (7)if(sp()!=0)else(23)
def _7():
    sa(sp()-1);
    sa(sr())
    return (8)if(sp()!=0)else(20)
def _8():
    sa(sp()-1);
    sa(sr())
    return (9)if(sp()!=0)else(22)
def _9():
    sa(sp()-1);
    sa(sr())
    return (10)if(sp()!=0)else(20)
def _10():
    sa(sp()-1);
    sa(sr())
    return (11)if(sp()!=0)else(21)
def _11():
    sa(sp()-1);
    sa(sr())
    return (12)if(sp()!=0)else(20)
def _12():
    sa(sp()-1);
    sa(sr())
    return (19)if(sp()!=0)else(13)
def _13():
    sa(((1)if((gr(15,0)+gr(16,0)+gr(17,0))-gr(5,1)!=0)else(0))+((0)if(gr(7,0)-9!=0)else(1)))
    return 14
def _14():
    return (18)if(sp()!=0)else(15)
def _15():
    sp()
    return (17)if(9<=gr(3,0))else(16)
def _16():
    gw(gr(7,0)+9,1,88)
    sa(58)
    sa(gr(3,0)+1)
    gw(3,0,gr(3,0)+1)
    sa(sp()+9);
    sa(0)
    v0=sp()
    v1=sp()
    gw(v1,v0,sp())
    return 1
def _17():
    global t0
    global t1
    global t2
    global t3
    global t4
    global t5
    global t6
    global t7
    global t8
    global t9
    global t10
    global t11
    global t12
    global t13
    global t13
    global t12
    global t11
    global t10
    global t9
    global t8
    global t7
    global t6
    global t5
    global t4
    global t3
    global t2
    global t1
    global t0
    t0=gr(10,0)-47
    t1=gr(17,0)-47
    t2=gr(18,0)-47
    t3=gr(17,0)-47
    t4=gr(15,0)-47
    t5=gr(16,0)-47
    t6=gr(15,0)-47
    t7=gr(13,0)-47
    t8=gr(14,0)-47
    t9=gr(13,0)-47
    t10=gr(11,0)-47
    t11=gr(12,0)-47
    t12=gr(11,0)-47
    t13=gr(10,0)-47
    print(gr(9,0)-47,end="",flush=True)
    print(t13,end="",flush=True)
    print(t12,end="",flush=True)
    print(t11,end="",flush=True)
    print(t10,end="",flush=True)
    print(t9,end="",flush=True)
    print(t8,end="",flush=True)
    print(t7,end="",flush=True)
    print(t6,end="",flush=True)
    print(t5,end="",flush=True)
    print(t4,end="",flush=True)
    print(t3,end="",flush=True)
    print(t2,end="",flush=True)
    print(t1,end="",flush=True)
    print(t0,end="",flush=True)
    return 26
def _18():
    sp()
    return 1
def _19():
    sa(((1)if((gr(17,0)+gr(18,0)+gr(10,0))-gr(5,1)!=0)else(0))+((1)if((gr(9,0)-48)>gr(7,0))else(0)))
    return 14
def _20():
    sa((1)if((gr(9,0)-48)>gr(7,0))else(0))
    return 14
def _21():
    sa(((1)if((gr(13,0)+gr(14,0)+gr(15,0))-gr(5,1)!=0)else(0))+((0)if(gr(7,0)-9!=0)else(1)))
    return 14
def _22():
    sa(((1)if((gr(11,0)+gr(12,0)+gr(13,0))-gr(5,1)!=0)else(0))+((0)if(gr(7,0)-9!=0)else(1)))
    return 14
def _23():
    gw(5,1,gr(9,0)+gr(10,0)+gr(11,0))
    sa((0)if(gr(7,0)-9!=0)else(1))
    return 14
def _24():
    sa((0)if(gr(7,0)-9!=0)else(1))
    return 14
def _25():
    sa((1)if(gr(7,0)>5)else(0))
    return 14
m=[_0,_1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13,_14,_15,_16,_17,_18,_19,_20,_21,_22,_23,_24,_25]
c=0
while c<26:
    c=m[c]()