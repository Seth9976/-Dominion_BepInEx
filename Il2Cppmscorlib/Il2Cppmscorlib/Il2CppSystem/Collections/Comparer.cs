using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Globalization;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Collections
{
	// Token: 0x02000471 RID: 1137
	[Serializable]
	public sealed class Comparer : Object
	{
		// Token: 0x0600440A RID: 17418 RVA: 0x001374E0 File Offset: 0x001356E0
		// Note: this type is marked as 'beforefieldinit'.
		static Comparer()
		{
			Il2CppClassPointerStore<Comparer>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections", "Comparer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Comparer>.NativeClassPtr);
			Comparer.NativeFieldInfoPtr_m_compareInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Comparer>.NativeClassPtr, "m_compareInfo");
			Comparer.NativeFieldInfoPtr_Default = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Comparer>.NativeClassPtr, "Default");
			Comparer.NativeFieldInfoPtr_DefaultInvariant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Comparer>.NativeClassPtr, "DefaultInvariant");
			Comparer.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Comparer>.NativeClassPtr, 100673174);
			Comparer.NativeMethodInfoPtr__ctor_Public_Void_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Comparer>.NativeClassPtr, 100673175);
			Comparer.NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Comparer>.NativeClassPtr, 100673176);
			Comparer.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Comparer>.NativeClassPtr, 100673177);
			Comparer.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Comparer>.NativeClassPtr, 100673178);
		}

		// Token: 0x0600440B RID: 17419 RVA: 0x001375B0 File Offset: 0x001357B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359562, XrefRangeEnd = 359563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Comparer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Comparer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Comparer.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600440C RID: 17420 RVA: 0x001375EC File Offset: 0x001357EC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 359564, RefRangeEnd = 359570, XrefRangeStart = 359563, XrefRangeEnd = 359564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Comparer(CultureInfo culture)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Comparer>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(culture);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Comparer.NativeMethodInfoPtr__ctor_Public_Void_CultureInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600440D RID: 17421 RVA: 0x00137638 File Offset: 0x00135838
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359570, XrefRangeEnd = 359589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Comparer(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Comparer>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Comparer.NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600440E RID: 17422 RVA: 0x0013769C File Offset: 0x0013589C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 359598, RefRangeEnd = 359599, XrefRangeStart = 359589, XrefRangeEnd = 359598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Compare(Object a, Object b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Comparer.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600440F RID: 17423 RVA: 0x001376FC File Offset: 0x001358FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359599, XrefRangeEnd = 359602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Comparer.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004410 RID: 17424 RVA: 0x0001A18C File Offset: 0x0001838C
		public Comparer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001151 RID: 4433
		// (get) Token: 0x06004411 RID: 17425 RVA: 0x00137758 File Offset: 0x00135958
		// (set) Token: 0x06004412 RID: 17426 RVA: 0x0001A195 File Offset: 0x00018395
		public unsafe CompareInfo m_compareInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Comparer.NativeFieldInfoPtr_m_compareInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CompareInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Comparer.NativeFieldInfoPtr_m_compareInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001152 RID: 4434
		// (get) Token: 0x06004413 RID: 17427 RVA: 0x00137788 File Offset: 0x00135988
		// (set) Token: 0x06004414 RID: 17428 RVA: 0x0001A1B4 File Offset: 0x000183B4
		public unsafe static Comparer Default
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Comparer.NativeFieldInfoPtr_Default, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparer>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Comparer.NativeFieldInfoPtr_Default, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001153 RID: 4435
		// (get) Token: 0x06004415 RID: 17429 RVA: 0x001377B0 File Offset: 0x001359B0
		// (set) Token: 0x06004416 RID: 17430 RVA: 0x0001A1C6 File Offset: 0x000183C6
		public unsafe static Comparer DefaultInvariant
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Comparer.NativeFieldInfoPtr_DefaultInvariant, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparer>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Comparer.NativeFieldInfoPtr_DefaultInvariant, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003772 RID: 14194
		private static readonly IntPtr NativeFieldInfoPtr_m_compareInfo;

		// Token: 0x04003773 RID: 14195
		private static readonly IntPtr NativeFieldInfoPtr_Default;

		// Token: 0x04003774 RID: 14196
		private static readonly IntPtr NativeFieldInfoPtr_DefaultInvariant;

		// Token: 0x04003775 RID: 14197
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04003776 RID: 14198
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_CultureInfo_0;

		// Token: 0x04003777 RID: 14199
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04003778 RID: 14200
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_Object_Object_0;

		// Token: 0x04003779 RID: 14201
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;
	}
}
