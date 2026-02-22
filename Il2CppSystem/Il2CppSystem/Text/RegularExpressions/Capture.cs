using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Text.RegularExpressions
{
	// Token: 0x0200004C RID: 76
	[Serializable]
	public class Capture : Object
	{
		// Token: 0x06000483 RID: 1155 RVA: 0x000222B4 File Offset: 0x000204B4
		// Note: this type is marked as 'beforefieldinit'.
		static Capture()
		{
			Il2CppClassPointerStore<Capture>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Text.RegularExpressions", "Capture");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Capture>.NativeClassPtr);
			Capture.NativeFieldInfoPtr__text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Capture>.NativeClassPtr, "_text");
			Capture.NativeFieldInfoPtr__index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Capture>.NativeClassPtr, "_index");
			Capture.NativeFieldInfoPtr__length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Capture>.NativeClassPtr, "_length");
			Capture.NativeMethodInfoPtr__ctor_Internal_Void_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Capture>.NativeClassPtr, 100663956);
			Capture.NativeMethodInfoPtr_get_Index_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Capture>.NativeClassPtr, 100663957);
			Capture.NativeMethodInfoPtr_get_Length_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Capture>.NativeClassPtr, 100663958);
			Capture.NativeMethodInfoPtr_get_Value_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Capture>.NativeClassPtr, 100663959);
			Capture.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Capture>.NativeClassPtr, 100663960);
			Capture.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Capture>.NativeClassPtr, 100663961);
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x00022398 File Offset: 0x00020598
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 37634, RefRangeEnd = 37639, XrefRangeStart = 37633, XrefRangeEnd = 37634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Capture(string text, int i, int l)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Capture>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref l;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Capture.NativeMethodInfoPtr__ctor_Internal_Void_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x06000485 RID: 1157 RVA: 0x00022400 File Offset: 0x00020600
		public unsafe int Index
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Capture.NativeMethodInfoPtr_get_Index_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x06000486 RID: 1158 RVA: 0x0002243C File Offset: 0x0002063C
		public unsafe int Length
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Capture.NativeMethodInfoPtr_get_Length_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x06000487 RID: 1159 RVA: 0x00022478 File Offset: 0x00020678
		public unsafe string Value
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 37641, RefRangeEnd = 37648, XrefRangeStart = 37639, XrefRangeEnd = 37641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Capture.NativeMethodInfoPtr_get_Value_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x000224B0 File Offset: 0x000206B0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 37641, RefRangeEnd = 37648, XrefRangeStart = 37641, XrefRangeEnd = 37648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Capture.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000489 RID: 1161 RVA: 0x000224F4 File Offset: 0x000206F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37648, XrefRangeEnd = 37651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Capture()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Capture>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Capture.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x00003B08 File Offset: 0x00001D08
		public Capture(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x0600048B RID: 1163 RVA: 0x00022530 File Offset: 0x00020730
		// (set) Token: 0x0600048C RID: 1164 RVA: 0x00003B11 File Offset: 0x00001D11
		public unsafe string _text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Capture.NativeFieldInfoPtr__text);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Capture.NativeFieldInfoPtr__text), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x0600048D RID: 1165 RVA: 0x00022558 File Offset: 0x00020758
		// (set) Token: 0x0600048E RID: 1166 RVA: 0x00003B30 File Offset: 0x00001D30
		public unsafe int _index
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Capture.NativeFieldInfoPtr__index);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Capture.NativeFieldInfoPtr__index)) = value;
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x0600048F RID: 1167 RVA: 0x00022580 File Offset: 0x00020780
		// (set) Token: 0x06000490 RID: 1168 RVA: 0x00003B4B File Offset: 0x00001D4B
		public unsafe int _length
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Capture.NativeFieldInfoPtr__length);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Capture.NativeFieldInfoPtr__length)) = value;
			}
		}

		// Token: 0x0400037E RID: 894
		private static readonly IntPtr NativeFieldInfoPtr__text;

		// Token: 0x0400037F RID: 895
		private static readonly IntPtr NativeFieldInfoPtr__index;

		// Token: 0x04000380 RID: 896
		private static readonly IntPtr NativeFieldInfoPtr__length;

		// Token: 0x04000381 RID: 897
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_Int32_Int32_0;

		// Token: 0x04000382 RID: 898
		private static readonly IntPtr NativeMethodInfoPtr_get_Index_Public_get_Int32_0;

		// Token: 0x04000383 RID: 899
		private static readonly IntPtr NativeMethodInfoPtr_get_Length_Public_get_Int32_0;

		// Token: 0x04000384 RID: 900
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_String_0;

		// Token: 0x04000385 RID: 901
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000386 RID: 902
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;
	}
}
