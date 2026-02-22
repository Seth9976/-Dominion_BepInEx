using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x02000077 RID: 119
	[Serializable]
	public class ArgumentOutOfRangeException : ArgumentException
	{
		// Token: 0x0600071E RID: 1822 RVA: 0x00041ED0 File Offset: 0x000400D0
		// Note: this type is marked as 'beforefieldinit'.
		static ArgumentOutOfRangeException()
		{
			Il2CppClassPointerStore<ArgumentOutOfRangeException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "ArgumentOutOfRangeException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArgumentOutOfRangeException>.NativeClassPtr);
			ArgumentOutOfRangeException.NativeFieldInfoPtr__rangeMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArgumentOutOfRangeException>.NativeClassPtr, "_rangeMessage");
			ArgumentOutOfRangeException.NativeFieldInfoPtr_m_actualValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArgumentOutOfRangeException>.NativeClassPtr, "m_actualValue");
			ArgumentOutOfRangeException.NativeMethodInfoPtr_get_RangeMessage_Private_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgumentOutOfRangeException>.NativeClassPtr, 100664401);
			ArgumentOutOfRangeException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgumentOutOfRangeException>.NativeClassPtr, 100664402);
			ArgumentOutOfRangeException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgumentOutOfRangeException>.NativeClassPtr, 100664403);
			ArgumentOutOfRangeException.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgumentOutOfRangeException>.NativeClassPtr, 100664404);
			ArgumentOutOfRangeException.NativeMethodInfoPtr__ctor_Public_Void_String_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgumentOutOfRangeException>.NativeClassPtr, 100664405);
			ArgumentOutOfRangeException.NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgumentOutOfRangeException>.NativeClassPtr, 100664406);
			ArgumentOutOfRangeException.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgumentOutOfRangeException>.NativeClassPtr, 100664407);
			ArgumentOutOfRangeException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgumentOutOfRangeException>.NativeClassPtr, 100664408);
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x0600071F RID: 1823 RVA: 0x00041FC8 File Offset: 0x000401C8
		public unsafe static string RangeMessage
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 276044, RefRangeEnd = 276046, XrefRangeStart = 276034, XrefRangeEnd = 276044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArgumentOutOfRangeException.NativeMethodInfoPtr_get_RangeMessage_Private_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000720 RID: 1824 RVA: 0x00041FF4 File Offset: 0x000401F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276046, XrefRangeEnd = 276050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArgumentOutOfRangeException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArgumentOutOfRangeException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArgumentOutOfRangeException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000721 RID: 1825 RVA: 0x00042030 File Offset: 0x00040230
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 276054, RefRangeEnd = 276073, XrefRangeStart = 276050, XrefRangeEnd = 276054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArgumentOutOfRangeException(string paramName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArgumentOutOfRangeException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(paramName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArgumentOutOfRangeException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000722 RID: 1826 RVA: 0x0004207C File Offset: 0x0004027C
		[CallerCount(98)]
		[CachedScanResults(RefRangeStart = 276076, RefRangeEnd = 276174, XrefRangeStart = 276073, XrefRangeEnd = 276076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArgumentOutOfRangeException(string paramName, string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArgumentOutOfRangeException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(paramName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArgumentOutOfRangeException.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000723 RID: 1827 RVA: 0x000420DC File Offset: 0x000402DC
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 276177, RefRangeEnd = 276185, XrefRangeStart = 276174, XrefRangeEnd = 276177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArgumentOutOfRangeException(string paramName, Object actualValue, string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArgumentOutOfRangeException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(paramName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(actualValue);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArgumentOutOfRangeException.NativeMethodInfoPtr__ctor_Public_Void_String_Object_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x06000724 RID: 1828 RVA: 0x0004214C File Offset: 0x0004034C
		public unsafe override string Message
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276185, XrefRangeEnd = 276198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArgumentOutOfRangeException.NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000725 RID: 1829 RVA: 0x00042190 File Offset: 0x00040390
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276198, XrefRangeEnd = 276217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void GetObjectData(SerializationInfo info, StreamingContext context)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArgumentOutOfRangeException.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000726 RID: 1830 RVA: 0x000421F4 File Offset: 0x000403F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276217, XrefRangeEnd = 276230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArgumentOutOfRangeException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArgumentOutOfRangeException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArgumentOutOfRangeException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000727 RID: 1831 RVA: 0x000044C5 File Offset: 0x000026C5
		public ArgumentOutOfRangeException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x06000728 RID: 1832 RVA: 0x00042258 File Offset: 0x00040458
		// (set) Token: 0x06000729 RID: 1833 RVA: 0x000044CE File Offset: 0x000026CE
		public unsafe static string _rangeMessage
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ArgumentOutOfRangeException.NativeFieldInfoPtr__rangeMessage, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ArgumentOutOfRangeException.NativeFieldInfoPtr__rangeMessage, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x0600072A RID: 1834 RVA: 0x00042278 File Offset: 0x00040478
		// (set) Token: 0x0600072B RID: 1835 RVA: 0x000044E0 File Offset: 0x000026E0
		public unsafe Object m_actualValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArgumentOutOfRangeException.NativeFieldInfoPtr_m_actualValue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArgumentOutOfRangeException.NativeFieldInfoPtr_m_actualValue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000517 RID: 1303
		private static readonly IntPtr NativeFieldInfoPtr__rangeMessage;

		// Token: 0x04000518 RID: 1304
		private static readonly IntPtr NativeFieldInfoPtr_m_actualValue;

		// Token: 0x04000519 RID: 1305
		private static readonly IntPtr NativeMethodInfoPtr_get_RangeMessage_Private_Static_get_String_0;

		// Token: 0x0400051A RID: 1306
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400051B RID: 1307
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x0400051C RID: 1308
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

		// Token: 0x0400051D RID: 1309
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Object_String_0;

		// Token: 0x0400051E RID: 1310
		private static readonly IntPtr NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0;

		// Token: 0x0400051F RID: 1311
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04000520 RID: 1312
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
