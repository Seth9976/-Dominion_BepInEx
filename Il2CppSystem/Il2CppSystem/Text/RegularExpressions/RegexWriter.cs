using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Text.RegularExpressions
{
	// Token: 0x02000062 RID: 98
	public sealed class RegexWriter : Object
	{
		// Token: 0x0600073A RID: 1850 RVA: 0x0002B658 File Offset: 0x00029858
		// Note: this type is marked as 'beforefieldinit'.
		static RegexWriter()
		{
			Il2CppClassPointerStore<RegexWriter>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Text.RegularExpressions", "RegexWriter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegexWriter>.NativeClassPtr);
			RegexWriter.NativeFieldInfoPtr__intStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexWriter>.NativeClassPtr, "_intStack");
			RegexWriter.NativeFieldInfoPtr__depth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexWriter>.NativeClassPtr, "_depth");
			RegexWriter.NativeFieldInfoPtr__emitted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexWriter>.NativeClassPtr, "_emitted");
			RegexWriter.NativeFieldInfoPtr__curpos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexWriter>.NativeClassPtr, "_curpos");
			RegexWriter.NativeFieldInfoPtr__stringhash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexWriter>.NativeClassPtr, "_stringhash");
			RegexWriter.NativeFieldInfoPtr__stringtable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexWriter>.NativeClassPtr, "_stringtable");
			RegexWriter.NativeFieldInfoPtr__counting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexWriter>.NativeClassPtr, "_counting");
			RegexWriter.NativeFieldInfoPtr__count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexWriter>.NativeClassPtr, "_count");
			RegexWriter.NativeFieldInfoPtr__trackcount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexWriter>.NativeClassPtr, "_trackcount");
			RegexWriter.NativeFieldInfoPtr__caps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexWriter>.NativeClassPtr, "_caps");
			RegexWriter.NativeMethodInfoPtr_Write_Internal_Static_RegexCode_RegexTree_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexWriter>.NativeClassPtr, 100664246);
			RegexWriter.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexWriter>.NativeClassPtr, 100664247);
			RegexWriter.NativeMethodInfoPtr_PushInt_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexWriter>.NativeClassPtr, 100664248);
			RegexWriter.NativeMethodInfoPtr_EmptyStack_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexWriter>.NativeClassPtr, 100664249);
			RegexWriter.NativeMethodInfoPtr_PopInt_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexWriter>.NativeClassPtr, 100664250);
			RegexWriter.NativeMethodInfoPtr_CurPos_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexWriter>.NativeClassPtr, 100664251);
			RegexWriter.NativeMethodInfoPtr_PatchJump_Internal_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexWriter>.NativeClassPtr, 100664252);
			RegexWriter.NativeMethodInfoPtr_Emit_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexWriter>.NativeClassPtr, 100664253);
			RegexWriter.NativeMethodInfoPtr_Emit_Internal_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexWriter>.NativeClassPtr, 100664254);
			RegexWriter.NativeMethodInfoPtr_Emit_Internal_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexWriter>.NativeClassPtr, 100664255);
			RegexWriter.NativeMethodInfoPtr_StringCode_Internal_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexWriter>.NativeClassPtr, 100664256);
			RegexWriter.NativeMethodInfoPtr_MakeException_Internal_ArgumentException_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexWriter>.NativeClassPtr, 100664257);
			RegexWriter.NativeMethodInfoPtr_MapCapnum_Internal_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexWriter>.NativeClassPtr, 100664258);
			RegexWriter.NativeMethodInfoPtr_RegexCodeFromRegexTree_Internal_RegexCode_RegexTree_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexWriter>.NativeClassPtr, 100664259);
			RegexWriter.NativeMethodInfoPtr_EmitFragment_Internal_Void_Int32_RegexNode_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexWriter>.NativeClassPtr, 100664260);
		}

		// Token: 0x0600073B RID: 1851 RVA: 0x0002B87C File Offset: 0x00029A7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40711, XrefRangeEnd = 40733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RegexCode Write(RegexTree t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexWriter.NativeMethodInfoPtr_Write_Internal_Static_RegexCode_RegexTree_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegexCode>(intPtr3) : null;
			}
		}

		// Token: 0x0600073C RID: 1852 RVA: 0x0002B8C0 File Offset: 0x00029AC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40733, XrefRangeEnd = 40751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexWriter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegexWriter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexWriter.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600073D RID: 1853 RVA: 0x0002B8FC File Offset: 0x00029AFC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40755, RefRangeEnd = 40757, XrefRangeStart = 40751, XrefRangeEnd = 40755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PushInt(int I)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref I;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexWriter.NativeMethodInfoPtr_PushInt_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600073E RID: 1854 RVA: 0x0002B93C File Offset: 0x00029B3C
		[CallerCount(0)]
		public unsafe bool EmptyStack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexWriter.NativeMethodInfoPtr_EmptyStack_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600073F RID: 1855 RVA: 0x0002B978 File Offset: 0x00029B78
		[CallerCount(0)]
		public unsafe int PopInt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexWriter.NativeMethodInfoPtr_PopInt_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000740 RID: 1856 RVA: 0x0002B9B4 File Offset: 0x00029BB4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 12781, RefRangeEnd = 12782, XrefRangeStart = 12781, XrefRangeEnd = 12782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CurPos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexWriter.NativeMethodInfoPtr_CurPos_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000741 RID: 1857 RVA: 0x0002B9F0 File Offset: 0x00029BF0
		[CallerCount(0)]
		public unsafe void PatchJump(int Offset, int jumpDest)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref Offset;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref jumpDest;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexWriter.NativeMethodInfoPtr_PatchJump_Internal_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000742 RID: 1858 RVA: 0x0002BA3C File Offset: 0x00029C3C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40757, RefRangeEnd = 40759, XrefRangeStart = 40757, XrefRangeEnd = 40757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Emit(int op)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref op;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexWriter.NativeMethodInfoPtr_Emit_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000743 RID: 1859 RVA: 0x0002BA7C File Offset: 0x00029C7C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40759, RefRangeEnd = 40761, XrefRangeStart = 40759, XrefRangeEnd = 40759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Emit(int op, int opd1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref op;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref opd1;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexWriter.NativeMethodInfoPtr_Emit_Internal_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000744 RID: 1860 RVA: 0x0002BAC8 File Offset: 0x00029CC8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 40761, RefRangeEnd = 40765, XrefRangeStart = 40761, XrefRangeEnd = 40761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Emit(int op, int opd1, int opd2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref op;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref opd1;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref opd2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexWriter.NativeMethodInfoPtr_Emit_Internal_Void_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000745 RID: 1861 RVA: 0x0002BB24 File Offset: 0x00029D24
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 40778, RefRangeEnd = 40781, XrefRangeStart = 40765, XrefRangeEnd = 40778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int StringCode(string str)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexWriter.NativeMethodInfoPtr_StringCode_Internal_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000746 RID: 1862 RVA: 0x0002BB74 File Offset: 0x00029D74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40781, XrefRangeEnd = 40785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArgumentException MakeException(string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexWriter.NativeMethodInfoPtr_MakeException_Internal_ArgumentException_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArgumentException>(intPtr3) : null;
			}
		}

		// Token: 0x06000747 RID: 1863 RVA: 0x0002BBC4 File Offset: 0x00029DC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 40786, RefRangeEnd = 40787, XrefRangeStart = 40785, XrefRangeEnd = 40786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int MapCapnum(int capnum)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capnum;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexWriter.NativeMethodInfoPtr_MapCapnum_Internal_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000748 RID: 1864 RVA: 0x0002BC10 File Offset: 0x00029E10
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 40858, RefRangeEnd = 40859, XrefRangeStart = 40787, XrefRangeEnd = 40858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexCode RegexCodeFromRegexTree(RegexTree tree)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tree);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexWriter.NativeMethodInfoPtr_RegexCodeFromRegexTree_Internal_RegexCode_RegexTree_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegexCode>(intPtr3) : null;
			}
		}

		// Token: 0x06000749 RID: 1865 RVA: 0x0002BC60 File Offset: 0x00029E60
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 40877, RefRangeEnd = 40880, XrefRangeStart = 40859, XrefRangeEnd = 40877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmitFragment(int nodetype, RegexNode node, int CurIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nodetype;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(node);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref CurIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexWriter.NativeMethodInfoPtr_EmitFragment_Internal_Void_Int32_RegexNode_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600074A RID: 1866 RVA: 0x00004D75 File Offset: 0x00002F75
		public RegexWriter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x0600074B RID: 1867 RVA: 0x0002BCC0 File Offset: 0x00029EC0
		// (set) Token: 0x0600074C RID: 1868 RVA: 0x00004D7E File Offset: 0x00002F7E
		public unsafe Il2CppStructArray<int> _intStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexWriter.NativeFieldInfoPtr__intStack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexWriter.NativeFieldInfoPtr__intStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x0600074D RID: 1869 RVA: 0x0002BCF0 File Offset: 0x00029EF0
		// (set) Token: 0x0600074E RID: 1870 RVA: 0x00004D9D File Offset: 0x00002F9D
		public unsafe int _depth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexWriter.NativeFieldInfoPtr__depth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexWriter.NativeFieldInfoPtr__depth)) = value;
			}
		}

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x0600074F RID: 1871 RVA: 0x0002BD18 File Offset: 0x00029F18
		// (set) Token: 0x06000750 RID: 1872 RVA: 0x00004DB8 File Offset: 0x00002FB8
		public unsafe Il2CppStructArray<int> _emitted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexWriter.NativeFieldInfoPtr__emitted);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexWriter.NativeFieldInfoPtr__emitted), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x06000751 RID: 1873 RVA: 0x0002BD48 File Offset: 0x00029F48
		// (set) Token: 0x06000752 RID: 1874 RVA: 0x00004DD7 File Offset: 0x00002FD7
		public unsafe int _curpos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexWriter.NativeFieldInfoPtr__curpos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexWriter.NativeFieldInfoPtr__curpos)) = value;
			}
		}

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x06000753 RID: 1875 RVA: 0x0002BD70 File Offset: 0x00029F70
		// (set) Token: 0x06000754 RID: 1876 RVA: 0x00004DF2 File Offset: 0x00002FF2
		public unsafe Dictionary<string, int> _stringhash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexWriter.NativeFieldInfoPtr__stringhash);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexWriter.NativeFieldInfoPtr__stringhash), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x06000755 RID: 1877 RVA: 0x0002BDA0 File Offset: 0x00029FA0
		// (set) Token: 0x06000756 RID: 1878 RVA: 0x00004E11 File Offset: 0x00003011
		public unsafe List<string> _stringtable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexWriter.NativeFieldInfoPtr__stringtable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexWriter.NativeFieldInfoPtr__stringtable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x06000757 RID: 1879 RVA: 0x0002BDD0 File Offset: 0x00029FD0
		// (set) Token: 0x06000758 RID: 1880 RVA: 0x00004E30 File Offset: 0x00003030
		public unsafe bool _counting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexWriter.NativeFieldInfoPtr__counting);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexWriter.NativeFieldInfoPtr__counting)) = value;
			}
		}

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x06000759 RID: 1881 RVA: 0x0002BDF8 File Offset: 0x00029FF8
		// (set) Token: 0x0600075A RID: 1882 RVA: 0x00004E4B File Offset: 0x0000304B
		public unsafe int _count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexWriter.NativeFieldInfoPtr__count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexWriter.NativeFieldInfoPtr__count)) = value;
			}
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x0600075B RID: 1883 RVA: 0x0002BE20 File Offset: 0x0002A020
		// (set) Token: 0x0600075C RID: 1884 RVA: 0x00004E66 File Offset: 0x00003066
		public unsafe int _trackcount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexWriter.NativeFieldInfoPtr__trackcount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexWriter.NativeFieldInfoPtr__trackcount)) = value;
			}
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x0600075D RID: 1885 RVA: 0x0002BE48 File Offset: 0x0002A048
		// (set) Token: 0x0600075E RID: 1886 RVA: 0x00004E81 File Offset: 0x00003081
		public unsafe Hashtable _caps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexWriter.NativeFieldInfoPtr__caps);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexWriter.NativeFieldInfoPtr__caps), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400055C RID: 1372
		private static readonly IntPtr NativeFieldInfoPtr__intStack;

		// Token: 0x0400055D RID: 1373
		private static readonly IntPtr NativeFieldInfoPtr__depth;

		// Token: 0x0400055E RID: 1374
		private static readonly IntPtr NativeFieldInfoPtr__emitted;

		// Token: 0x0400055F RID: 1375
		private static readonly IntPtr NativeFieldInfoPtr__curpos;

		// Token: 0x04000560 RID: 1376
		private static readonly IntPtr NativeFieldInfoPtr__stringhash;

		// Token: 0x04000561 RID: 1377
		private static readonly IntPtr NativeFieldInfoPtr__stringtable;

		// Token: 0x04000562 RID: 1378
		private static readonly IntPtr NativeFieldInfoPtr__counting;

		// Token: 0x04000563 RID: 1379
		private static readonly IntPtr NativeFieldInfoPtr__count;

		// Token: 0x04000564 RID: 1380
		private static readonly IntPtr NativeFieldInfoPtr__trackcount;

		// Token: 0x04000565 RID: 1381
		private static readonly IntPtr NativeFieldInfoPtr__caps;

		// Token: 0x04000566 RID: 1382
		private static readonly IntPtr NativeMethodInfoPtr_Write_Internal_Static_RegexCode_RegexTree_0;

		// Token: 0x04000567 RID: 1383
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04000568 RID: 1384
		private static readonly IntPtr NativeMethodInfoPtr_PushInt_Internal_Void_Int32_0;

		// Token: 0x04000569 RID: 1385
		private static readonly IntPtr NativeMethodInfoPtr_EmptyStack_Internal_Boolean_0;

		// Token: 0x0400056A RID: 1386
		private static readonly IntPtr NativeMethodInfoPtr_PopInt_Internal_Int32_0;

		// Token: 0x0400056B RID: 1387
		private static readonly IntPtr NativeMethodInfoPtr_CurPos_Internal_Int32_0;

		// Token: 0x0400056C RID: 1388
		private static readonly IntPtr NativeMethodInfoPtr_PatchJump_Internal_Void_Int32_Int32_0;

		// Token: 0x0400056D RID: 1389
		private static readonly IntPtr NativeMethodInfoPtr_Emit_Internal_Void_Int32_0;

		// Token: 0x0400056E RID: 1390
		private static readonly IntPtr NativeMethodInfoPtr_Emit_Internal_Void_Int32_Int32_0;

		// Token: 0x0400056F RID: 1391
		private static readonly IntPtr NativeMethodInfoPtr_Emit_Internal_Void_Int32_Int32_Int32_0;

		// Token: 0x04000570 RID: 1392
		private static readonly IntPtr NativeMethodInfoPtr_StringCode_Internal_Int32_String_0;

		// Token: 0x04000571 RID: 1393
		private static readonly IntPtr NativeMethodInfoPtr_MakeException_Internal_ArgumentException_String_0;

		// Token: 0x04000572 RID: 1394
		private static readonly IntPtr NativeMethodInfoPtr_MapCapnum_Internal_Int32_Int32_0;

		// Token: 0x04000573 RID: 1395
		private static readonly IntPtr NativeMethodInfoPtr_RegexCodeFromRegexTree_Internal_RegexCode_RegexTree_0;

		// Token: 0x04000574 RID: 1396
		private static readonly IntPtr NativeMethodInfoPtr_EmitFragment_Internal_Void_Int32_RegexNode_Int32_0;
	}
}
