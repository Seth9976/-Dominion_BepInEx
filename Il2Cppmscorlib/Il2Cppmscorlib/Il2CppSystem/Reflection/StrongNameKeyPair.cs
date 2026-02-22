using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020001E3 RID: 483
	[Serializable]
	public class StrongNameKeyPair : Object
	{
		// Token: 0x06001F2B RID: 7979 RVA: 0x000ADCD8 File Offset: 0x000ABED8
		// Note: this type is marked as 'beforefieldinit'.
		static StrongNameKeyPair()
		{
			Il2CppClassPointerStore<StrongNameKeyPair>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "StrongNameKeyPair");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StrongNameKeyPair>.NativeClassPtr);
			StrongNameKeyPair.NativeFieldInfoPtr__publicKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StrongNameKeyPair>.NativeClassPtr, "_publicKey");
			StrongNameKeyPair.NativeFieldInfoPtr__keyPairContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StrongNameKeyPair>.NativeClassPtr, "_keyPairContainer");
			StrongNameKeyPair.NativeFieldInfoPtr__keyPairExported = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StrongNameKeyPair>.NativeClassPtr, "_keyPairExported");
			StrongNameKeyPair.NativeFieldInfoPtr__keyPairArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StrongNameKeyPair>.NativeClassPtr, "_keyPairArray");
			StrongNameKeyPair.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StrongNameKeyPair>.NativeClassPtr, 100668465);
			StrongNameKeyPair.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StrongNameKeyPair>.NativeClassPtr, 100668466);
			StrongNameKeyPair.NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StrongNameKeyPair>.NativeClassPtr, 100668467);
		}

		// Token: 0x06001F2C RID: 7980 RVA: 0x000ADD94 File Offset: 0x000ABF94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319180, XrefRangeEnd = 319207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StrongNameKeyPair(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StrongNameKeyPair>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StrongNameKeyPair.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F2D RID: 7981 RVA: 0x000ADDF8 File Offset: 0x000ABFF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 319207, XrefRangeEnd = 319227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Runtime_Serialization_ISerializable_GetObjectData(SerializationInfo info, StreamingContext context)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StrongNameKeyPair.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F2E RID: 7982 RVA: 0x000ADE54 File Offset: 0x000AC054
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Runtime_Serialization_IDeserializationCallback_OnDeserialization(Object sender)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StrongNameKeyPair.NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F2F RID: 7983 RVA: 0x0000AA81 File Offset: 0x00008C81
		public StrongNameKeyPair(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000665 RID: 1637
		// (get) Token: 0x06001F30 RID: 7984 RVA: 0x000ADE98 File Offset: 0x000AC098
		// (set) Token: 0x06001F31 RID: 7985 RVA: 0x0000AA8A File Offset: 0x00008C8A
		public unsafe Il2CppStructArray<byte> _publicKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StrongNameKeyPair.NativeFieldInfoPtr__publicKey);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StrongNameKeyPair.NativeFieldInfoPtr__publicKey), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000666 RID: 1638
		// (get) Token: 0x06001F32 RID: 7986 RVA: 0x000ADEC8 File Offset: 0x000AC0C8
		// (set) Token: 0x06001F33 RID: 7987 RVA: 0x0000AAA9 File Offset: 0x00008CA9
		public unsafe string _keyPairContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StrongNameKeyPair.NativeFieldInfoPtr__keyPairContainer);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StrongNameKeyPair.NativeFieldInfoPtr__keyPairContainer), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000667 RID: 1639
		// (get) Token: 0x06001F34 RID: 7988 RVA: 0x000ADEF0 File Offset: 0x000AC0F0
		// (set) Token: 0x06001F35 RID: 7989 RVA: 0x0000AAC8 File Offset: 0x00008CC8
		public unsafe bool _keyPairExported
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StrongNameKeyPair.NativeFieldInfoPtr__keyPairExported);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StrongNameKeyPair.NativeFieldInfoPtr__keyPairExported)) = value;
			}
		}

		// Token: 0x17000668 RID: 1640
		// (get) Token: 0x06001F36 RID: 7990 RVA: 0x000ADF18 File Offset: 0x000AC118
		// (set) Token: 0x06001F37 RID: 7991 RVA: 0x0000AAE3 File Offset: 0x00008CE3
		public unsafe Il2CppStructArray<byte> _keyPairArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StrongNameKeyPair.NativeFieldInfoPtr__keyPairArray);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StrongNameKeyPair.NativeFieldInfoPtr__keyPairArray), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001C4D RID: 7245
		private static readonly IntPtr NativeFieldInfoPtr__publicKey;

		// Token: 0x04001C4E RID: 7246
		private static readonly IntPtr NativeFieldInfoPtr__keyPairContainer;

		// Token: 0x04001C4F RID: 7247
		private static readonly IntPtr NativeFieldInfoPtr__keyPairExported;

		// Token: 0x04001C50 RID: 7248
		private static readonly IntPtr NativeFieldInfoPtr__keyPairArray;

		// Token: 0x04001C51 RID: 7249
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04001C52 RID: 7250
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04001C53 RID: 7251
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0;
	}
}
