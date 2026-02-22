using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020001B3 RID: 435
	[Serializable]
	public sealed class Missing : Object
	{
		// Token: 0x06001C25 RID: 7205 RVA: 0x000A0AF4 File Offset: 0x0009ECF4
		// Note: this type is marked as 'beforefieldinit'.
		static Missing()
		{
			Il2CppClassPointerStore<Missing>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "Missing");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Missing>.NativeClassPtr);
			Missing.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Missing>.NativeClassPtr, "Value");
			Missing.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Missing>.NativeClassPtr, 100668000);
			Missing.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Missing>.NativeClassPtr, 100668001);
		}

		// Token: 0x06001C26 RID: 7206 RVA: 0x000A0B60 File Offset: 0x0009ED60
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Missing()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Missing>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Missing.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C27 RID: 7207 RVA: 0x000A0B9C File Offset: 0x0009ED9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 317229, XrefRangeEnd = 317241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Runtime_Serialization_ISerializable_GetObjectData(SerializationInfo info, StreamingContext context)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Missing.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C28 RID: 7208 RVA: 0x00009ADA File Offset: 0x00007CDA
		public Missing(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000591 RID: 1425
		// (get) Token: 0x06001C29 RID: 7209 RVA: 0x000A0BF8 File Offset: 0x0009EDF8
		// (set) Token: 0x06001C2A RID: 7210 RVA: 0x00009AE3 File Offset: 0x00007CE3
		public unsafe static Missing Value
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Missing.NativeFieldInfoPtr_Value, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Missing>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Missing.NativeFieldInfoPtr_Value, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040019DD RID: 6621
		private static readonly IntPtr NativeFieldInfoPtr_Value;

		// Token: 0x040019DE RID: 6622
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x040019DF RID: 6623
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;
	}
}
