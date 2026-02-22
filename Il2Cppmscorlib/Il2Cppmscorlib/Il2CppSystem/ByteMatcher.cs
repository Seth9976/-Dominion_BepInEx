using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem
{
	// Token: 0x02000135 RID: 309
	public class ByteMatcher : Object
	{
		// Token: 0x06001666 RID: 5734 RVA: 0x0008714C File Offset: 0x0008534C
		// Note: this type is marked as 'beforefieldinit'.
		static ByteMatcher()
		{
			Il2CppClassPointerStore<ByteMatcher>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "ByteMatcher");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ByteMatcher>.NativeClassPtr);
			ByteMatcher.NativeFieldInfoPtr_map = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ByteMatcher>.NativeClassPtr, "map");
			ByteMatcher.NativeFieldInfoPtr_starts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ByteMatcher>.NativeClassPtr, "starts");
			ByteMatcher.NativeMethodInfoPtr_AddMapping_Public_Void_TermInfoStrings_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteMatcher>.NativeClassPtr, 100667070);
			ByteMatcher.NativeMethodInfoPtr_Sort_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteMatcher>.NativeClassPtr, 100667071);
			ByteMatcher.NativeMethodInfoPtr_StartsWith_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteMatcher>.NativeClassPtr, 100667072);
			ByteMatcher.NativeMethodInfoPtr_Match_Public_TermInfoStrings_Il2CppStructArray_1_Char_Int32_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteMatcher>.NativeClassPtr, 100667073);
			ByteMatcher.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteMatcher>.NativeClassPtr, 100667074);
		}

		// Token: 0x06001667 RID: 5735 RVA: 0x00087208 File Offset: 0x00085408
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 309020, RefRangeEnd = 309023, XrefRangeStart = 309011, XrefRangeEnd = 309020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddMapping(TermInfoStrings key, Il2CppStructArray<byte> val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref key;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(val);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ByteMatcher.NativeMethodInfoPtr_AddMapping_Public_Void_TermInfoStrings_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001668 RID: 5736 RVA: 0x00087258 File Offset: 0x00085458
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Sort()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ByteMatcher.NativeMethodInfoPtr_Sort_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001669 RID: 5737 RVA: 0x0008728C File Offset: 0x0008548C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 309026, RefRangeEnd = 309027, XrefRangeStart = 309023, XrefRangeEnd = 309026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool StartsWith(int c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ByteMatcher.NativeMethodInfoPtr_StartsWith_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600166A RID: 5738 RVA: 0x000872D8 File Offset: 0x000854D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 309050, RefRangeEnd = 309051, XrefRangeStart = 309027, XrefRangeEnd = 309050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TermInfoStrings Match(Il2CppStructArray<char> buffer, int offset, int length, out int used)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &used;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ByteMatcher.NativeMethodInfoPtr_Match_Public_TermInfoStrings_Il2CppStructArray_1_Char_Int32_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600166B RID: 5739 RVA: 0x00087350 File Offset: 0x00085550
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 309059, RefRangeEnd = 309060, XrefRangeStart = 309051, XrefRangeEnd = 309059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ByteMatcher()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ByteMatcher>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ByteMatcher.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600166C RID: 5740 RVA: 0x00007DA4 File Offset: 0x00005FA4
		public ByteMatcher(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x0600166D RID: 5741 RVA: 0x0008738C File Offset: 0x0008558C
		// (set) Token: 0x0600166E RID: 5742 RVA: 0x00007DAD File Offset: 0x00005FAD
		public unsafe Hashtable map
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ByteMatcher.NativeFieldInfoPtr_map);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ByteMatcher.NativeFieldInfoPtr_map), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x0600166F RID: 5743 RVA: 0x000873BC File Offset: 0x000855BC
		// (set) Token: 0x06001670 RID: 5744 RVA: 0x00007DCC File Offset: 0x00005FCC
		public unsafe Hashtable starts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ByteMatcher.NativeFieldInfoPtr_starts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ByteMatcher.NativeFieldInfoPtr_starts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040012EA RID: 4842
		private static readonly IntPtr NativeFieldInfoPtr_map;

		// Token: 0x040012EB RID: 4843
		private static readonly IntPtr NativeFieldInfoPtr_starts;

		// Token: 0x040012EC RID: 4844
		private static readonly IntPtr NativeMethodInfoPtr_AddMapping_Public_Void_TermInfoStrings_Il2CppStructArray_1_Byte_0;

		// Token: 0x040012ED RID: 4845
		private static readonly IntPtr NativeMethodInfoPtr_Sort_Public_Void_0;

		// Token: 0x040012EE RID: 4846
		private static readonly IntPtr NativeMethodInfoPtr_StartsWith_Public_Boolean_Int32_0;

		// Token: 0x040012EF RID: 4847
		private static readonly IntPtr NativeMethodInfoPtr_Match_Public_TermInfoStrings_Il2CppStructArray_1_Char_Int32_Int32_byref_Int32_0;

		// Token: 0x040012F0 RID: 4848
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
