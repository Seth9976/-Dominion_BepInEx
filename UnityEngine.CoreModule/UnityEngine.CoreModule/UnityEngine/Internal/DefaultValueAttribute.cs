using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Internal
{
	// Token: 0x0200012C RID: 300
	[Serializable]
	public class DefaultValueAttribute : Attribute
	{
		// Token: 0x06001782 RID: 6018 RVA: 0x000585CC File Offset: 0x000567CC
		// Note: this type is marked as 'beforefieldinit'.
		static DefaultValueAttribute()
		{
			Il2CppClassPointerStore<DefaultValueAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Internal", "DefaultValueAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultValueAttribute>.NativeClassPtr);
			DefaultValueAttribute.NativeFieldInfoPtr_DefaultValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultValueAttribute>.NativeClassPtr, "DefaultValue");
			DefaultValueAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultValueAttribute>.NativeClassPtr, 100665079);
			DefaultValueAttribute.NativeMethodInfoPtr_get_Value_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultValueAttribute>.NativeClassPtr, 100665080);
			DefaultValueAttribute.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultValueAttribute>.NativeClassPtr, 100665081);
			DefaultValueAttribute.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultValueAttribute>.NativeClassPtr, 100665082);
		}

		// Token: 0x06001783 RID: 6019 RVA: 0x00058660 File Offset: 0x00056860
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 14927, RefRangeEnd = 14932, XrefRangeStart = 14927, XrefRangeEnd = 14932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DefaultValueAttribute(string value)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultValueAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultValueAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x06001784 RID: 6020 RVA: 0x000586AC File Offset: 0x000568AC
		public unsafe Object Value
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 58949, RefRangeEnd = 58951, XrefRangeStart = 58949, XrefRangeEnd = 58951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultValueAttribute.NativeMethodInfoPtr_get_Value_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001785 RID: 6021 RVA: 0x000586EC File Offset: 0x000568EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82179, XrefRangeEnd = 82181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DefaultValueAttribute.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001786 RID: 6022 RVA: 0x00058744 File Offset: 0x00056944
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82181, XrefRangeEnd = 82182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DefaultValueAttribute.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001787 RID: 6023 RVA: 0x0000D2DF File Offset: 0x0000B4DF
		public DefaultValueAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x06001788 RID: 6024 RVA: 0x0005878C File Offset: 0x0005698C
		// (set) Token: 0x06001789 RID: 6025 RVA: 0x0000D2E8 File Offset: 0x0000B4E8
		public unsafe Object DefaultValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultValueAttribute.NativeFieldInfoPtr_DefaultValue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultValueAttribute.NativeFieldInfoPtr_DefaultValue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400110D RID: 4365
		private static readonly IntPtr NativeFieldInfoPtr_DefaultValue;

		// Token: 0x0400110E RID: 4366
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x0400110F RID: 4367
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_Object_0;

		// Token: 0x04001110 RID: 4368
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001111 RID: 4369
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
	}
}
