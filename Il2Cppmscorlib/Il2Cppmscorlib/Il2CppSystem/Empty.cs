using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x0200009D RID: 157
	[Serializable]
	public sealed class Empty : Object
	{
		// Token: 0x06000B11 RID: 2833 RVA: 0x00054180 File Offset: 0x00052380
		// Note: this type is marked as 'beforefieldinit'.
		static Empty()
		{
			Il2CppClassPointerStore<Empty>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Empty");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Empty>.NativeClassPtr);
			Empty.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Empty>.NativeClassPtr, "Value");
			Empty.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Empty>.NativeClassPtr, 100665153);
			Empty.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Empty>.NativeClassPtr, 100665154);
			Empty.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Empty>.NativeClassPtr, 100665155);
		}

		// Token: 0x06000B12 RID: 2834 RVA: 0x00054200 File Offset: 0x00052400
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Empty()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Empty>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Empty.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B13 RID: 2835 RVA: 0x0005423C File Offset: 0x0005243C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282078, XrefRangeEnd = 282080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Empty.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000B14 RID: 2836 RVA: 0x00054274 File Offset: 0x00052474
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 282080, XrefRangeEnd = 282081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Empty.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B15 RID: 2837 RVA: 0x00004DD4 File Offset: 0x00002FD4
		public Empty(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x06000B16 RID: 2838 RVA: 0x000542D0 File Offset: 0x000524D0
		// (set) Token: 0x06000B17 RID: 2839 RVA: 0x00004DDD File Offset: 0x00002FDD
		public unsafe static Empty Value
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Empty.NativeFieldInfoPtr_Value, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Empty>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Empty.NativeFieldInfoPtr_Value, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000942 RID: 2370
		private static readonly IntPtr NativeFieldInfoPtr_Value;

		// Token: 0x04000943 RID: 2371
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04000944 RID: 2372
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000945 RID: 2373
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;
	}
}
