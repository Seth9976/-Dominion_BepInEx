using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Text.RegularExpressions
{
	// Token: 0x02000050 RID: 80
	public sealed class RegexCode : Object
	{
		// Token: 0x060004F8 RID: 1272 RVA: 0x00023DD0 File Offset: 0x00021FD0
		// Note: this type is marked as 'beforefieldinit'.
		static RegexCode()
		{
			Il2CppClassPointerStore<RegexCode>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Text.RegularExpressions", "RegexCode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegexCode>.NativeClassPtr);
			RegexCode.NativeFieldInfoPtr_Onerep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Onerep");
			RegexCode.NativeFieldInfoPtr_Notonerep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Notonerep");
			RegexCode.NativeFieldInfoPtr_Setrep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Setrep");
			RegexCode.NativeFieldInfoPtr_Oneloop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Oneloop");
			RegexCode.NativeFieldInfoPtr_Notoneloop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Notoneloop");
			RegexCode.NativeFieldInfoPtr_Setloop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Setloop");
			RegexCode.NativeFieldInfoPtr_Onelazy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Onelazy");
			RegexCode.NativeFieldInfoPtr_Notonelazy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Notonelazy");
			RegexCode.NativeFieldInfoPtr_Setlazy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Setlazy");
			RegexCode.NativeFieldInfoPtr_One = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "One");
			RegexCode.NativeFieldInfoPtr_Notone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Notone");
			RegexCode.NativeFieldInfoPtr_Set = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Set");
			RegexCode.NativeFieldInfoPtr_Multi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Multi");
			RegexCode.NativeFieldInfoPtr_Ref = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Ref");
			RegexCode.NativeFieldInfoPtr_Bol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Bol");
			RegexCode.NativeFieldInfoPtr_Eol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Eol");
			RegexCode.NativeFieldInfoPtr_Boundary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Boundary");
			RegexCode.NativeFieldInfoPtr_Nonboundary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Nonboundary");
			RegexCode.NativeFieldInfoPtr_Beginning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Beginning");
			RegexCode.NativeFieldInfoPtr_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Start");
			RegexCode.NativeFieldInfoPtr_EndZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "EndZ");
			RegexCode.NativeFieldInfoPtr_End = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "End");
			RegexCode.NativeFieldInfoPtr_Nothing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Nothing");
			RegexCode.NativeFieldInfoPtr_Lazybranch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Lazybranch");
			RegexCode.NativeFieldInfoPtr_Branchmark = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Branchmark");
			RegexCode.NativeFieldInfoPtr_Lazybranchmark = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Lazybranchmark");
			RegexCode.NativeFieldInfoPtr_Nullcount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Nullcount");
			RegexCode.NativeFieldInfoPtr_Setcount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Setcount");
			RegexCode.NativeFieldInfoPtr_Branchcount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Branchcount");
			RegexCode.NativeFieldInfoPtr_Lazybranchcount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Lazybranchcount");
			RegexCode.NativeFieldInfoPtr_Nullmark = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Nullmark");
			RegexCode.NativeFieldInfoPtr_Setmark = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Setmark");
			RegexCode.NativeFieldInfoPtr_Capturemark = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Capturemark");
			RegexCode.NativeFieldInfoPtr_Getmark = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Getmark");
			RegexCode.NativeFieldInfoPtr_Setjump = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Setjump");
			RegexCode.NativeFieldInfoPtr_Backjump = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Backjump");
			RegexCode.NativeFieldInfoPtr_Forejump = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Forejump");
			RegexCode.NativeFieldInfoPtr_Testref = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Testref");
			RegexCode.NativeFieldInfoPtr_Goto = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Goto");
			RegexCode.NativeFieldInfoPtr_Prune = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Prune");
			RegexCode.NativeFieldInfoPtr_Stop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Stop");
			RegexCode.NativeFieldInfoPtr_ECMABoundary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "ECMABoundary");
			RegexCode.NativeFieldInfoPtr_NonECMABoundary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "NonECMABoundary");
			RegexCode.NativeFieldInfoPtr_Mask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Mask");
			RegexCode.NativeFieldInfoPtr_Rtl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Rtl");
			RegexCode.NativeFieldInfoPtr_Back = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Back");
			RegexCode.NativeFieldInfoPtr_Back2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Back2");
			RegexCode.NativeFieldInfoPtr_Ci = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "Ci");
			RegexCode.NativeFieldInfoPtr__codes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "_codes");
			RegexCode.NativeFieldInfoPtr__strings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "_strings");
			RegexCode.NativeFieldInfoPtr__trackcount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "_trackcount");
			RegexCode.NativeFieldInfoPtr__caps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "_caps");
			RegexCode.NativeFieldInfoPtr__capsize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "_capsize");
			RegexCode.NativeFieldInfoPtr__fcPrefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "_fcPrefix");
			RegexCode.NativeFieldInfoPtr__bmPrefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "_bmPrefix");
			RegexCode.NativeFieldInfoPtr__anchors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "_anchors");
			RegexCode.NativeFieldInfoPtr__rightToLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, "_rightToLeft");
			RegexCode.NativeMethodInfoPtr__ctor_Internal_Void_Il2CppStructArray_1_Int32_List_1_String_Int32_Hashtable_Int32_RegexBoyerMoore_RegexPrefix_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, 100664016);
			RegexCode.NativeMethodInfoPtr_OpcodeBacktracks_Internal_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCode>.NativeClassPtr, 100664017);
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x0002429C File Offset: 0x0002249C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39053, XrefRangeEnd = 39062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexCode(Il2CppStructArray<int> codes, List<string> stringlist, int trackcount, Hashtable caps, int capsize, RegexBoyerMoore bmPrefix, RegexPrefix fcPrefix, int anchors, bool rightToLeft)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegexCode>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(codes);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stringlist);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref trackcount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(caps);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref capsize;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bmPrefix);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(fcPrefix);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref anchors;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rightToLeft;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCode.NativeMethodInfoPtr__ctor_Internal_Void_Il2CppStructArray_1_Int32_List_1_String_Int32_Hashtable_Int32_RegexBoyerMoore_RegexPrefix_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x0002436C File Offset: 0x0002256C
		[CallerCount(0)]
		public unsafe static bool OpcodeBacktracks(int Op)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref Op;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCode.NativeMethodInfoPtr_OpcodeBacktracks_Internal_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x00003DA3 File Offset: 0x00001FA3
		public RegexCode(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x060004FC RID: 1276 RVA: 0x000243AC File Offset: 0x000225AC
		// (set) Token: 0x060004FD RID: 1277 RVA: 0x00003DAC File Offset: 0x00001FAC
		public unsafe static int Onerep
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RegexCode.NativeFieldInfoPtr_Onerep, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCode.NativeFieldInfoPtr_Onerep, (void*)(&value));
			}
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x060004FE RID: 1278 RVA: 0x000243C8 File Offset: 0x000225C8
		// (set) Token: 0x060004FF RID: 1279 RVA: 0x00003DBA File Offset: 0x00001FBA
		public unsafe static int Notonerep
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RegexCode.NativeFieldInfoPtr_Notonerep, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCode.NativeFieldInfoPtr_Notonerep, (void*)(&value));
			}
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x06000500 RID: 1280 RVA: 0x000243E4 File Offset: 0x000225E4
		// (set) Token: 0x06000501 RID: 1281 RVA: 0x00003DC8 File Offset: 0x00001FC8
		public unsafe static int Setrep
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RegexCode.NativeFieldInfoPtr_Setrep, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCode.NativeFieldInfoPtr_Setrep, (void*)(&value));
			}
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x06000502 RID: 1282 RVA: 0x00024400 File Offset: 0x00022600
		// (set) Token: 0x06000503 RID: 1283 RVA: 0x00003DD6 File Offset: 0x00001FD6
		public unsafe static int Oneloop
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RegexCode.NativeFieldInfoPtr_Oneloop, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCode.NativeFieldInfoPtr_Oneloop, (void*)(&value));
			}
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x06000504 RID: 1284 RVA: 0x0002441C File Offset: 0x0002261C
		// (set) Token: 0x06000505 RID: 1285 RVA: 0x00003DE4 File Offset: 0x00001FE4
		public unsafe static int Notoneloop
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RegexCode.NativeFieldInfoPtr_Notoneloop, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCode.NativeFieldInfoPtr_Notoneloop, (void*)(&value));
			}
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x06000506 RID: 1286 RVA: 0x00024438 File Offset: 0x00022638
		// (set) Token: 0x06000507 RID: 1287 RVA: 0x00003DF2 File Offset: 0x00001FF2
		public unsafe static int Setloop
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RegexCode.NativeFieldInfoPtr_Setloop, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCode.NativeFieldInfoPtr_Setloop, (void*)(&value));
			}
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x06000508 RID: 1288 RVA: 0x00024454 File Offset: 0x00022654
		// (set) Token: 0x06000509 RID: 1289 RVA: 0x00003E00 File Offset: 0x00002000
		public unsafe static int Onelazy
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RegexCode.NativeFieldInfoPtr_Onelazy, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCode.NativeFieldInfoPtr_Onelazy, (void*)(&value));
			}
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x0600050A RID: 1290 RVA: 0x00024470 File Offset: 0x00022670
		// (set) Token: 0x0600050B RID: 1291 RVA: 0x00003E0E File Offset: 0x0000200E
		public unsafe static int Notonelazy
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RegexCode.NativeFieldInfoPtr_Notonelazy, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCode.NativeFieldInfoPtr_Notonelazy, (void*)(&value));
			}
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x0600050C RID: 1292 RVA: 0x0002448C File Offset: 0x0002268C
		// (set) Token: 0x0600050D RID: 1293 RVA: 0x00003E1C File Offset: 0x0000201C
		public unsafe static int Setlazy
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RegexCode.NativeFieldInfoPtr_Setlazy, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCode.NativeFieldInfoPtr_Setlazy, (void*)(&value));
			}
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x0600050E RID: 1294 RVA: 0x000244A8 File Offset: 0x000226A8
		// (set) Token: 0x0600050F RID: 1295 RVA: 0x00003E2A File Offset: 0x0000202A
		public unsafe static int One
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RegexCode.NativeFieldInfoPtr_One, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCode.NativeFieldInfoPtr_One, (void*)(&value));
			}
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x06000510 RID: 1296 RVA: 0x000244C4 File Offset: 0x000226C4
		// (set) Token: 0x06000511 RID: 1297 RVA: 0x00003E38 File Offset: 0x00002038
		public unsafe static int Notone
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RegexCode.NativeFieldInfoPtr_Notone, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCode.NativeFieldInfoPtr_Notone, (void*)(&value));
			}
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x06000512 RID: 1298 RVA: 0x000244E0 File Offset: 0x000226E0
		// (set) Token: 0x06000513 RID: 1299 RVA: 0x00003E46 File Offset: 0x00002046
		public unsafe static int Set
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RegexCode.NativeFieldInfoPtr_Set, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCode.NativeFieldInfoPtr_Set, (void*)(&value));
			}
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x06000514 RID: 1300 RVA: 0x000244FC File Offset: 0x000226FC
		// (set) Token: 0x06000515 RID: 1301 RVA: 0x00003E54 File Offset: 0x00002054
		public unsafe static int Multi
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RegexCode.NativeFieldInfoPtr_Multi, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCode.NativeFieldInfoPtr_Multi, (void*)(&value));
			}
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x06000516 RID: 1302 RVA: 0x00024518 File Offset: 0x00022718
		// (set) Token: 0x06000517 RID: 1303 RVA: 0x00003E62 File Offset: 0x00002062
		public unsafe static int Ref
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RegexCode.NativeFieldInfoPtr_Ref, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCode.NativeFieldInfoPtr_Ref, (void*)(&value));
			}
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x06000518 RID: 1304 RVA: 0x00024534 File Offset: 0x00022734
		// (set) Token: 0x06000519 RID: 1305 RVA: 0x00003E70 File Offset: 0x00002070
		public unsafe static int Bol
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RegexCode.NativeFieldInfoPtr_Bol, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCode.NativeFieldInfoPtr_Bol, (void*)(&value));
			}
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x0600051A RID: 1306 RVA: 0x00024550 File Offset: 0x00022750
		// (set) Token: 0x0600051B RID: 1307 RVA: 0x00003E7E File Offset: 0x0000207E
		public unsafe static int Eol
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RegexCode.NativeFieldInfoPtr_Eol, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCode.NativeFieldInfoPtr_Eol, (void*)(&value));
			}
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x0600051C RID: 1308 RVA: 0x0002456C File Offset: 0x0002276C
		// (set) Token: 0x0600051D RID: 1309 RVA: 0x00003E8C File Offset: 0x0000208C
		public unsafe static int Boundary
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RegexCode.NativeFieldInfoPtr_Boundary, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCode.NativeFieldInfoPtr_Boundary, (void*)(&value));
			}
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x0600051E RID: 1310 RVA: 0x00024588 File Offset: 0x00022788
		// (set) Token: 0x0600051F RID: 1311 RVA: 0x00003E9A File Offset: 0x0000209A
		public unsafe static int Nonboundary
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RegexCode.NativeFieldInfoPtr_Nonboundary, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCode.NativeFieldInfoPtr_Nonboundary, (void*)(&value));
			}
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x06000520 RID: 1312 RVA: 0x000245A4 File Offset: 0x000227A4
		// (set) Token: 0x06000521 RID: 1313 RVA: 0x00003EA8 File Offset: 0x000020A8
		public unsafe static int Beginning
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RegexCode.NativeFieldInfoPtr_Beginning, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCode.NativeFieldInfoPtr_Beginning, (void*)(&value));
			}
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x06000522 RID: 1314 RVA: 0x000245C0 File Offset: 0x000227C0
		// (set) Token: 0x06000523 RID: 1315 RVA: 0x00003EB6 File Offset: 0x000020B6
		public unsafe static int Start
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RegexCode.NativeFieldInfoPtr_Start, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCode.NativeFieldInfoPtr_Start, (void*)(&value));
			}
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x06000524 RID: 1316 RVA: 0x000245DC File Offset: 0x000227DC
		// (set) Token: 0x06000525 RID: 1317 RVA: 0x00003EC4 File Offset: 0x000020C4
		public unsafe static int EndZ
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RegexCode.NativeFieldInfoPtr_EndZ, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCode.NativeFieldInfoPtr_EndZ, (void*)(&value));
			}
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x06000526 RID: 1318 RVA: 0x000245F8 File Offset: 0x000227F8
		// (set) Token: 0x06000527 RID: 1319 RVA: 0x00003ED2 File Offset: 0x000020D2
		public unsafe static int End
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RegexCode.NativeFieldInfoPtr_End, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCode.NativeFieldInfoPtr_End, (void*)(&value));
			}
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x06000528 RID: 1320 RVA: 0x00024614 File Offset: 0x00022814
		// (set) Token: 0x06000529 RID: 1321 RVA: 0x00003EE0 File Offset: 0x000020E0
		public unsafe static int Nothing
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RegexCode.NativeFieldInfoPtr_Nothing, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCode.NativeFieldInfoPtr_Nothing, (void*)(&value));
			}
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x0600052A RID: 1322 RVA: 0x00024630 File Offset: 0x00022830
		// (set) Token: 0x0600052B RID: 1323 RVA: 0x00003EEE File Offset: 0x000020EE
		public unsafe static int Lazybranch
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RegexCode.NativeFieldInfoPtr_Lazybranch, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCode.NativeFieldInfoPtr_Lazybranch, (void*)(&value));
			}
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x0600052C RID: 1324 RVA: 0x0002464C File Offset: 0x0002284C
		// (set) Token: 0x0600052D RID: 1325 RVA: 0x00003EFC File Offset: 0x000020FC
		public unsafe static int Branchmark
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RegexCode.NativeFieldInfoPtr_Branchmark, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCode.NativeFieldInfoPtr_Branchmark, (void*)(&value));
			}
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x0600052E RID: 1326 RVA: 0x00024668 File Offset: 0x00022868
		// (set) Token: 0x0600052F RID: 1327 RVA: 0x00003F0A File Offset: 0x0000210A
		public unsafe static int Lazybranchmark
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RegexCode.NativeFieldInfoPtr_Lazybranchmark, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCode.NativeFieldInfoPtr_Lazybranchmark, (void*)(&value));
			}
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x06000530 RID: 1328 RVA: 0x00024684 File Offset: 0x00022884
		// (set) Token: 0x06000531 RID: 1329 RVA: 0x00003F18 File Offset: 0x00002118
		public unsafe static int Nullcount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RegexCode.NativeFieldInfoPtr_Nullcount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCode.NativeFieldInfoPtr_Nullcount, (void*)(&value));
			}
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x06000532 RID: 1330 RVA: 0x000246A0 File Offset: 0x000228A0
		// (set) Token: 0x06000533 RID: 1331 RVA: 0x00003F26 File Offset: 0x00002126
		public unsafe static int Setcount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RegexCode.NativeFieldInfoPtr_Setcount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCode.NativeFieldInfoPtr_Setcount, (void*)(&value));
			}
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x06000534 RID: 1332 RVA: 0x000246BC File Offset: 0x000228BC
		// (set) Token: 0x06000535 RID: 1333 RVA: 0x00003F34 File Offset: 0x00002134
		public unsafe static int Branchcount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RegexCode.NativeFieldInfoPtr_Branchcount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCode.NativeFieldInfoPtr_Branchcount, (void*)(&value));
			}
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x06000536 RID: 1334 RVA: 0x000246D8 File Offset: 0x000228D8
		// (set) Token: 0x06000537 RID: 1335 RVA: 0x00003F42 File Offset: 0x00002142
		public unsafe static int Lazybranchcount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RegexCode.NativeFieldInfoPtr_Lazybranchcount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCode.NativeFieldInfoPtr_Lazybranchcount, (void*)(&value));
			}
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x06000538 RID: 1336 RVA: 0x000246F4 File Offset: 0x000228F4
		// (set) Token: 0x06000539 RID: 1337 RVA: 0x00003F50 File Offset: 0x00002150
		public unsafe static int Nullmark
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RegexCode.NativeFieldInfoPtr_Nullmark, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCode.NativeFieldInfoPtr_Nullmark, (void*)(&value));
			}
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x0600053A RID: 1338 RVA: 0x00024710 File Offset: 0x00022910
		// (set) Token: 0x0600053B RID: 1339 RVA: 0x00003F5E File Offset: 0x0000215E
		public unsafe static int Setmark
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RegexCode.NativeFieldInfoPtr_Setmark, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCode.NativeFieldInfoPtr_Setmark, (void*)(&value));
			}
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x0600053C RID: 1340 RVA: 0x0002472C File Offset: 0x0002292C
		// (set) Token: 0x0600053D RID: 1341 RVA: 0x00003F6C File Offset: 0x0000216C
		public unsafe static int Capturemark
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RegexCode.NativeFieldInfoPtr_Capturemark, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCode.NativeFieldInfoPtr_Capturemark, (void*)(&value));
			}
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x0600053E RID: 1342 RVA: 0x00024748 File Offset: 0x00022948
		// (set) Token: 0x0600053F RID: 1343 RVA: 0x00003F7A File Offset: 0x0000217A
		public unsafe static int Getmark
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RegexCode.NativeFieldInfoPtr_Getmark, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCode.NativeFieldInfoPtr_Getmark, (void*)(&value));
			}
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x06000540 RID: 1344 RVA: 0x00024764 File Offset: 0x00022964
		// (set) Token: 0x06000541 RID: 1345 RVA: 0x00003F88 File Offset: 0x00002188
		public unsafe static int Setjump
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RegexCode.NativeFieldInfoPtr_Setjump, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCode.NativeFieldInfoPtr_Setjump, (void*)(&value));
			}
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x06000542 RID: 1346 RVA: 0x00024780 File Offset: 0x00022980
		// (set) Token: 0x06000543 RID: 1347 RVA: 0x00003F96 File Offset: 0x00002196
		public unsafe static int Backjump
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RegexCode.NativeFieldInfoPtr_Backjump, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCode.NativeFieldInfoPtr_Backjump, (void*)(&value));
			}
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x06000544 RID: 1348 RVA: 0x0002479C File Offset: 0x0002299C
		// (set) Token: 0x06000545 RID: 1349 RVA: 0x00003FA4 File Offset: 0x000021A4
		public unsafe static int Forejump
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RegexCode.NativeFieldInfoPtr_Forejump, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCode.NativeFieldInfoPtr_Forejump, (void*)(&value));
			}
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x06000546 RID: 1350 RVA: 0x000247B8 File Offset: 0x000229B8
		// (set) Token: 0x06000547 RID: 1351 RVA: 0x00003FB2 File Offset: 0x000021B2
		public unsafe static int Testref
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RegexCode.NativeFieldInfoPtr_Testref, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCode.NativeFieldInfoPtr_Testref, (void*)(&value));
			}
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x06000548 RID: 1352 RVA: 0x000247D4 File Offset: 0x000229D4
		// (set) Token: 0x06000549 RID: 1353 RVA: 0x00003FC0 File Offset: 0x000021C0
		public unsafe static int Goto
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RegexCode.NativeFieldInfoPtr_Goto, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCode.NativeFieldInfoPtr_Goto, (void*)(&value));
			}
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x0600054A RID: 1354 RVA: 0x000247F0 File Offset: 0x000229F0
		// (set) Token: 0x0600054B RID: 1355 RVA: 0x00003FCE File Offset: 0x000021CE
		public unsafe static int Prune
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RegexCode.NativeFieldInfoPtr_Prune, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCode.NativeFieldInfoPtr_Prune, (void*)(&value));
			}
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x0600054C RID: 1356 RVA: 0x0002480C File Offset: 0x00022A0C
		// (set) Token: 0x0600054D RID: 1357 RVA: 0x00003FDC File Offset: 0x000021DC
		public unsafe static int Stop
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RegexCode.NativeFieldInfoPtr_Stop, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCode.NativeFieldInfoPtr_Stop, (void*)(&value));
			}
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x0600054E RID: 1358 RVA: 0x00024828 File Offset: 0x00022A28
		// (set) Token: 0x0600054F RID: 1359 RVA: 0x00003FEA File Offset: 0x000021EA
		public unsafe static int ECMABoundary
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RegexCode.NativeFieldInfoPtr_ECMABoundary, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCode.NativeFieldInfoPtr_ECMABoundary, (void*)(&value));
			}
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x06000550 RID: 1360 RVA: 0x00024844 File Offset: 0x00022A44
		// (set) Token: 0x06000551 RID: 1361 RVA: 0x00003FF8 File Offset: 0x000021F8
		public unsafe static int NonECMABoundary
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RegexCode.NativeFieldInfoPtr_NonECMABoundary, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCode.NativeFieldInfoPtr_NonECMABoundary, (void*)(&value));
			}
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x06000552 RID: 1362 RVA: 0x00024860 File Offset: 0x00022A60
		// (set) Token: 0x06000553 RID: 1363 RVA: 0x00004006 File Offset: 0x00002206
		public unsafe static int Mask
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RegexCode.NativeFieldInfoPtr_Mask, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCode.NativeFieldInfoPtr_Mask, (void*)(&value));
			}
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x06000554 RID: 1364 RVA: 0x0002487C File Offset: 0x00022A7C
		// (set) Token: 0x06000555 RID: 1365 RVA: 0x00004014 File Offset: 0x00002214
		public unsafe static int Rtl
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RegexCode.NativeFieldInfoPtr_Rtl, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCode.NativeFieldInfoPtr_Rtl, (void*)(&value));
			}
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x06000556 RID: 1366 RVA: 0x00024898 File Offset: 0x00022A98
		// (set) Token: 0x06000557 RID: 1367 RVA: 0x00004022 File Offset: 0x00002222
		public unsafe static int Back
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RegexCode.NativeFieldInfoPtr_Back, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCode.NativeFieldInfoPtr_Back, (void*)(&value));
			}
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x06000558 RID: 1368 RVA: 0x000248B4 File Offset: 0x00022AB4
		// (set) Token: 0x06000559 RID: 1369 RVA: 0x00004030 File Offset: 0x00002230
		public unsafe static int Back2
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RegexCode.NativeFieldInfoPtr_Back2, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCode.NativeFieldInfoPtr_Back2, (void*)(&value));
			}
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x0600055A RID: 1370 RVA: 0x000248D0 File Offset: 0x00022AD0
		// (set) Token: 0x0600055B RID: 1371 RVA: 0x0000403E File Offset: 0x0000223E
		public unsafe static int Ci
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RegexCode.NativeFieldInfoPtr_Ci, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCode.NativeFieldInfoPtr_Ci, (void*)(&value));
			}
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x0600055C RID: 1372 RVA: 0x000248EC File Offset: 0x00022AEC
		// (set) Token: 0x0600055D RID: 1373 RVA: 0x0000404C File Offset: 0x0000224C
		public unsafe Il2CppStructArray<int> _codes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexCode.NativeFieldInfoPtr__codes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexCode.NativeFieldInfoPtr__codes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x0600055E RID: 1374 RVA: 0x0002491C File Offset: 0x00022B1C
		// (set) Token: 0x0600055F RID: 1375 RVA: 0x0000406B File Offset: 0x0000226B
		public unsafe Il2CppStringArray _strings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexCode.NativeFieldInfoPtr__strings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexCode.NativeFieldInfoPtr__strings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x06000560 RID: 1376 RVA: 0x0002494C File Offset: 0x00022B4C
		// (set) Token: 0x06000561 RID: 1377 RVA: 0x0000408A File Offset: 0x0000228A
		public unsafe int _trackcount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexCode.NativeFieldInfoPtr__trackcount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexCode.NativeFieldInfoPtr__trackcount)) = value;
			}
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x06000562 RID: 1378 RVA: 0x00024974 File Offset: 0x00022B74
		// (set) Token: 0x06000563 RID: 1379 RVA: 0x000040A5 File Offset: 0x000022A5
		public unsafe Hashtable _caps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexCode.NativeFieldInfoPtr__caps);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexCode.NativeFieldInfoPtr__caps), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x06000564 RID: 1380 RVA: 0x000249A4 File Offset: 0x00022BA4
		// (set) Token: 0x06000565 RID: 1381 RVA: 0x000040C4 File Offset: 0x000022C4
		public unsafe int _capsize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexCode.NativeFieldInfoPtr__capsize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexCode.NativeFieldInfoPtr__capsize)) = value;
			}
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x06000566 RID: 1382 RVA: 0x000249CC File Offset: 0x00022BCC
		// (set) Token: 0x06000567 RID: 1383 RVA: 0x000040DF File Offset: 0x000022DF
		public unsafe RegexPrefix _fcPrefix
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexCode.NativeFieldInfoPtr__fcPrefix);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RegexPrefix>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexCode.NativeFieldInfoPtr__fcPrefix), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x06000568 RID: 1384 RVA: 0x000249FC File Offset: 0x00022BFC
		// (set) Token: 0x06000569 RID: 1385 RVA: 0x000040FE File Offset: 0x000022FE
		public unsafe RegexBoyerMoore _bmPrefix
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexCode.NativeFieldInfoPtr__bmPrefix);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RegexBoyerMoore>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexCode.NativeFieldInfoPtr__bmPrefix), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x0600056A RID: 1386 RVA: 0x00024A2C File Offset: 0x00022C2C
		// (set) Token: 0x0600056B RID: 1387 RVA: 0x0000411D File Offset: 0x0000231D
		public unsafe int _anchors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexCode.NativeFieldInfoPtr__anchors);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexCode.NativeFieldInfoPtr__anchors)) = value;
			}
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x0600056C RID: 1388 RVA: 0x00024A54 File Offset: 0x00022C54
		// (set) Token: 0x0600056D RID: 1389 RVA: 0x00004138 File Offset: 0x00002338
		public unsafe bool _rightToLeft
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexCode.NativeFieldInfoPtr__rightToLeft);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexCode.NativeFieldInfoPtr__rightToLeft)) = value;
			}
		}

		// Token: 0x040003D0 RID: 976
		private static readonly IntPtr NativeFieldInfoPtr_Onerep;

		// Token: 0x040003D1 RID: 977
		private static readonly IntPtr NativeFieldInfoPtr_Notonerep;

		// Token: 0x040003D2 RID: 978
		private static readonly IntPtr NativeFieldInfoPtr_Setrep;

		// Token: 0x040003D3 RID: 979
		private static readonly IntPtr NativeFieldInfoPtr_Oneloop;

		// Token: 0x040003D4 RID: 980
		private static readonly IntPtr NativeFieldInfoPtr_Notoneloop;

		// Token: 0x040003D5 RID: 981
		private static readonly IntPtr NativeFieldInfoPtr_Setloop;

		// Token: 0x040003D6 RID: 982
		private static readonly IntPtr NativeFieldInfoPtr_Onelazy;

		// Token: 0x040003D7 RID: 983
		private static readonly IntPtr NativeFieldInfoPtr_Notonelazy;

		// Token: 0x040003D8 RID: 984
		private static readonly IntPtr NativeFieldInfoPtr_Setlazy;

		// Token: 0x040003D9 RID: 985
		private static readonly IntPtr NativeFieldInfoPtr_One;

		// Token: 0x040003DA RID: 986
		private static readonly IntPtr NativeFieldInfoPtr_Notone;

		// Token: 0x040003DB RID: 987
		private static readonly IntPtr NativeFieldInfoPtr_Set;

		// Token: 0x040003DC RID: 988
		private static readonly IntPtr NativeFieldInfoPtr_Multi;

		// Token: 0x040003DD RID: 989
		private static readonly IntPtr NativeFieldInfoPtr_Ref;

		// Token: 0x040003DE RID: 990
		private static readonly IntPtr NativeFieldInfoPtr_Bol;

		// Token: 0x040003DF RID: 991
		private static readonly IntPtr NativeFieldInfoPtr_Eol;

		// Token: 0x040003E0 RID: 992
		private static readonly IntPtr NativeFieldInfoPtr_Boundary;

		// Token: 0x040003E1 RID: 993
		private static readonly IntPtr NativeFieldInfoPtr_Nonboundary;

		// Token: 0x040003E2 RID: 994
		private static readonly IntPtr NativeFieldInfoPtr_Beginning;

		// Token: 0x040003E3 RID: 995
		private static readonly IntPtr NativeFieldInfoPtr_Start;

		// Token: 0x040003E4 RID: 996
		private static readonly IntPtr NativeFieldInfoPtr_EndZ;

		// Token: 0x040003E5 RID: 997
		private static readonly IntPtr NativeFieldInfoPtr_End;

		// Token: 0x040003E6 RID: 998
		private static readonly IntPtr NativeFieldInfoPtr_Nothing;

		// Token: 0x040003E7 RID: 999
		private static readonly IntPtr NativeFieldInfoPtr_Lazybranch;

		// Token: 0x040003E8 RID: 1000
		private static readonly IntPtr NativeFieldInfoPtr_Branchmark;

		// Token: 0x040003E9 RID: 1001
		private static readonly IntPtr NativeFieldInfoPtr_Lazybranchmark;

		// Token: 0x040003EA RID: 1002
		private static readonly IntPtr NativeFieldInfoPtr_Nullcount;

		// Token: 0x040003EB RID: 1003
		private static readonly IntPtr NativeFieldInfoPtr_Setcount;

		// Token: 0x040003EC RID: 1004
		private static readonly IntPtr NativeFieldInfoPtr_Branchcount;

		// Token: 0x040003ED RID: 1005
		private static readonly IntPtr NativeFieldInfoPtr_Lazybranchcount;

		// Token: 0x040003EE RID: 1006
		private static readonly IntPtr NativeFieldInfoPtr_Nullmark;

		// Token: 0x040003EF RID: 1007
		private static readonly IntPtr NativeFieldInfoPtr_Setmark;

		// Token: 0x040003F0 RID: 1008
		private static readonly IntPtr NativeFieldInfoPtr_Capturemark;

		// Token: 0x040003F1 RID: 1009
		private static readonly IntPtr NativeFieldInfoPtr_Getmark;

		// Token: 0x040003F2 RID: 1010
		private static readonly IntPtr NativeFieldInfoPtr_Setjump;

		// Token: 0x040003F3 RID: 1011
		private static readonly IntPtr NativeFieldInfoPtr_Backjump;

		// Token: 0x040003F4 RID: 1012
		private static readonly IntPtr NativeFieldInfoPtr_Forejump;

		// Token: 0x040003F5 RID: 1013
		private static readonly IntPtr NativeFieldInfoPtr_Testref;

		// Token: 0x040003F6 RID: 1014
		private static readonly IntPtr NativeFieldInfoPtr_Goto;

		// Token: 0x040003F7 RID: 1015
		private static readonly IntPtr NativeFieldInfoPtr_Prune;

		// Token: 0x040003F8 RID: 1016
		private static readonly IntPtr NativeFieldInfoPtr_Stop;

		// Token: 0x040003F9 RID: 1017
		private static readonly IntPtr NativeFieldInfoPtr_ECMABoundary;

		// Token: 0x040003FA RID: 1018
		private static readonly IntPtr NativeFieldInfoPtr_NonECMABoundary;

		// Token: 0x040003FB RID: 1019
		private static readonly IntPtr NativeFieldInfoPtr_Mask;

		// Token: 0x040003FC RID: 1020
		private static readonly IntPtr NativeFieldInfoPtr_Rtl;

		// Token: 0x040003FD RID: 1021
		private static readonly IntPtr NativeFieldInfoPtr_Back;

		// Token: 0x040003FE RID: 1022
		private static readonly IntPtr NativeFieldInfoPtr_Back2;

		// Token: 0x040003FF RID: 1023
		private static readonly IntPtr NativeFieldInfoPtr_Ci;

		// Token: 0x04000400 RID: 1024
		private static readonly IntPtr NativeFieldInfoPtr__codes;

		// Token: 0x04000401 RID: 1025
		private static readonly IntPtr NativeFieldInfoPtr__strings;

		// Token: 0x04000402 RID: 1026
		private static readonly IntPtr NativeFieldInfoPtr__trackcount;

		// Token: 0x04000403 RID: 1027
		private static readonly IntPtr NativeFieldInfoPtr__caps;

		// Token: 0x04000404 RID: 1028
		private static readonly IntPtr NativeFieldInfoPtr__capsize;

		// Token: 0x04000405 RID: 1029
		private static readonly IntPtr NativeFieldInfoPtr__fcPrefix;

		// Token: 0x04000406 RID: 1030
		private static readonly IntPtr NativeFieldInfoPtr__bmPrefix;

		// Token: 0x04000407 RID: 1031
		private static readonly IntPtr NativeFieldInfoPtr__anchors;

		// Token: 0x04000408 RID: 1032
		private static readonly IntPtr NativeFieldInfoPtr__rightToLeft;

		// Token: 0x04000409 RID: 1033
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Il2CppStructArray_1_Int32_List_1_String_Int32_Hashtable_Int32_RegexBoyerMoore_RegexPrefix_Int32_Boolean_0;

		// Token: 0x0400040A RID: 1034
		private static readonly IntPtr NativeMethodInfoPtr_OpcodeBacktracks_Internal_Static_Boolean_Int32_0;
	}
}
