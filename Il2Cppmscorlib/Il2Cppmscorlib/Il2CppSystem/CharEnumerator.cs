using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000086 RID: 134
	[Serializable]
	public sealed class CharEnumerator : Object
	{
		// Token: 0x06000851 RID: 2129 RVA: 0x000478D0 File Offset: 0x00045AD0
		// Note: this type is marked as 'beforefieldinit'.
		static CharEnumerator()
		{
			Il2CppClassPointerStore<CharEnumerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "CharEnumerator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharEnumerator>.NativeClassPtr);
			CharEnumerator.NativeFieldInfoPtr_str = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharEnumerator>.NativeClassPtr, "str");
			CharEnumerator.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharEnumerator>.NativeClassPtr, "index");
			CharEnumerator.NativeFieldInfoPtr_currentElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharEnumerator>.NativeClassPtr, "currentElement");
			CharEnumerator.NativeMethodInfoPtr__ctor_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharEnumerator>.NativeClassPtr, 100664630);
			CharEnumerator.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharEnumerator>.NativeClassPtr, 100664631);
			CharEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharEnumerator>.NativeClassPtr, 100664632);
			CharEnumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharEnumerator>.NativeClassPtr, 100664633);
			CharEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharEnumerator>.NativeClassPtr, 100664634);
			CharEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharEnumerator>.NativeClassPtr, 100664635);
			CharEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharEnumerator>.NativeClassPtr, 100664636);
			CharEnumerator.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharEnumerator>.NativeClassPtr, 100664637);
		}

		// Token: 0x06000852 RID: 2130 RVA: 0x000479DC File Offset: 0x00045BDC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 41420, RefRangeEnd = 41422, XrefRangeStart = 41420, XrefRangeEnd = 41422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharEnumerator(string str)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharEnumerator>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharEnumerator.NativeMethodInfoPtr__ctor_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000853 RID: 2131 RVA: 0x00047A28 File Offset: 0x00045C28
		[CallerCount(92)]
		[CachedScanResults(RefRangeStart = 267191, RefRangeEnd = 267283, XrefRangeStart = 267191, XrefRangeEnd = 267283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharEnumerator.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000854 RID: 2132 RVA: 0x00047A68 File Offset: 0x00045C68
		[CallerCount(0)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000855 RID: 2133 RVA: 0x00047AA4 File Offset: 0x00045CA4
		[CallerCount(0)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharEnumerator.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x06000856 RID: 2134 RVA: 0x00047AD8 File Offset: 0x00045CD8
		public unsafe Object System.Collections.IEnumerator.Current
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278033, XrefRangeEnd = 278036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharEnumerator.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x06000857 RID: 2135 RVA: 0x00047B18 File Offset: 0x00045D18
		public unsafe char Current
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000858 RID: 2136 RVA: 0x00047B54 File Offset: 0x00045D54
		[CallerCount(0)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000859 RID: 2137 RVA: 0x00047B88 File Offset: 0x00045D88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278036, XrefRangeEnd = 278039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharEnumerator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharEnumerator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharEnumerator.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600085A RID: 2138 RVA: 0x000047C0 File Offset: 0x000029C0
		public CharEnumerator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x0600085B RID: 2139 RVA: 0x00047BC4 File Offset: 0x00045DC4
		// (set) Token: 0x0600085C RID: 2140 RVA: 0x000047C9 File Offset: 0x000029C9
		public unsafe string str
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharEnumerator.NativeFieldInfoPtr_str);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharEnumerator.NativeFieldInfoPtr_str), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x0600085D RID: 2141 RVA: 0x00047BEC File Offset: 0x00045DEC
		// (set) Token: 0x0600085E RID: 2142 RVA: 0x000047E8 File Offset: 0x000029E8
		public unsafe int index
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharEnumerator.NativeFieldInfoPtr_index);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharEnumerator.NativeFieldInfoPtr_index)) = value;
			}
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x0600085F RID: 2143 RVA: 0x00047C14 File Offset: 0x00045E14
		// (set) Token: 0x06000860 RID: 2144 RVA: 0x00004803 File Offset: 0x00002A03
		public unsafe char currentElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharEnumerator.NativeFieldInfoPtr_currentElement);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharEnumerator.NativeFieldInfoPtr_currentElement)) = value;
			}
		}

		// Token: 0x04000625 RID: 1573
		private static readonly IntPtr NativeFieldInfoPtr_str;

		// Token: 0x04000626 RID: 1574
		private static readonly IntPtr NativeFieldInfoPtr_index;

		// Token: 0x04000627 RID: 1575
		private static readonly IntPtr NativeFieldInfoPtr_currentElement;

		// Token: 0x04000628 RID: 1576
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_0;

		// Token: 0x04000629 RID: 1577
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;

		// Token: 0x0400062A RID: 1578
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x0400062B RID: 1579
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400062C RID: 1580
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x0400062D RID: 1581
		private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Char_0;

		// Token: 0x0400062E RID: 1582
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400062F RID: 1583
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;
	}
}
