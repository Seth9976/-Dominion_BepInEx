using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Globalization;

namespace Il2CppSystem.Collections
{
	// Token: 0x0200046F RID: 1135
	[Serializable]
	public class CaseInsensitiveHashCodeProvider : Object
	{
		// Token: 0x060043E5 RID: 17381 RVA: 0x00136938 File Offset: 0x00134B38
		// Note: this type is marked as 'beforefieldinit'.
		static CaseInsensitiveHashCodeProvider()
		{
			Il2CppClassPointerStore<CaseInsensitiveHashCodeProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections", "CaseInsensitiveHashCodeProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CaseInsensitiveHashCodeProvider>.NativeClassPtr);
			CaseInsensitiveHashCodeProvider.NativeFieldInfoPtr_m_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CaseInsensitiveHashCodeProvider>.NativeClassPtr, "m_text");
			CaseInsensitiveHashCodeProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaseInsensitiveHashCodeProvider>.NativeClassPtr, 100673145);
			CaseInsensitiveHashCodeProvider.NativeMethodInfoPtr__ctor_Public_Void_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaseInsensitiveHashCodeProvider>.NativeClassPtr, 100673146);
			CaseInsensitiveHashCodeProvider.NativeMethodInfoPtr_get_Default_Public_Static_get_CaseInsensitiveHashCodeProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaseInsensitiveHashCodeProvider>.NativeClassPtr, 100673147);
			CaseInsensitiveHashCodeProvider.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaseInsensitiveHashCodeProvider>.NativeClassPtr, 100673148);
		}

		// Token: 0x060043E6 RID: 17382 RVA: 0x001369CC File Offset: 0x00134BCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359415, XrefRangeEnd = 359420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CaseInsensitiveHashCodeProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CaseInsensitiveHashCodeProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CaseInsensitiveHashCodeProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060043E7 RID: 17383 RVA: 0x00136A08 File Offset: 0x00134C08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 359421, RefRangeEnd = 359422, XrefRangeStart = 359420, XrefRangeEnd = 359421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CaseInsensitiveHashCodeProvider(CultureInfo culture)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CaseInsensitiveHashCodeProvider>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(culture);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CaseInsensitiveHashCodeProvider.NativeMethodInfoPtr__ctor_Public_Void_CultureInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700114A RID: 4426
		// (get) Token: 0x060043E8 RID: 17384 RVA: 0x00136A54 File Offset: 0x00134C54
		public unsafe static CaseInsensitiveHashCodeProvider Default
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 359430, RefRangeEnd = 359432, XrefRangeStart = 359422, XrefRangeEnd = 359430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CaseInsensitiveHashCodeProvider.NativeMethodInfoPtr_get_Default_Public_Static_get_CaseInsensitiveHashCodeProvider_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CaseInsensitiveHashCodeProvider>(intPtr3) : null;
			}
		}

		// Token: 0x060043E9 RID: 17385 RVA: 0x00136A88 File Offset: 0x00134C88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359432, XrefRangeEnd = 359441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int GetHashCode(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CaseInsensitiveHashCodeProvider.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060043EA RID: 17386 RVA: 0x0001A13C File Offset: 0x0001833C
		public CaseInsensitiveHashCodeProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001149 RID: 4425
		// (get) Token: 0x060043EB RID: 17387 RVA: 0x00136AD8 File Offset: 0x00134CD8
		// (set) Token: 0x060043EC RID: 17388 RVA: 0x0001A145 File Offset: 0x00018345
		public unsafe TextInfo m_text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CaseInsensitiveHashCodeProvider.NativeFieldInfoPtr_m_text);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CaseInsensitiveHashCodeProvider.NativeFieldInfoPtr_m_text), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003753 RID: 14163
		private static readonly IntPtr NativeFieldInfoPtr_m_text;

		// Token: 0x04003754 RID: 14164
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003755 RID: 14165
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_CultureInfo_0;

		// Token: 0x04003756 RID: 14166
		private static readonly IntPtr NativeMethodInfoPtr_get_Default_Public_Static_get_CaseInsensitiveHashCodeProvider_0;

		// Token: 0x04003757 RID: 14167
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_Object_0;
	}
}
