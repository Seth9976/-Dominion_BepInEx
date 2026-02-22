using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x02000346 RID: 838
	[Serializable]
	public class SerializationException : SystemException
	{
		// Token: 0x060035B2 RID: 13746 RVA: 0x001056F4 File Offset: 0x001038F4
		// Note: this type is marked as 'beforefieldinit'.
		static SerializationException()
		{
			Il2CppClassPointerStore<SerializationException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "SerializationException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializationException>.NativeClassPtr);
			SerializationException.NativeFieldInfoPtr__nullMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializationException>.NativeClassPtr, "_nullMessage");
			SerializationException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationException>.NativeClassPtr, 100671582);
			SerializationException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationException>.NativeClassPtr, 100671583);
			SerializationException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationException>.NativeClassPtr, 100671584);
			SerializationException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationException>.NativeClassPtr, 100671585);
		}

		// Token: 0x060035B3 RID: 13747 RVA: 0x00105788 File Offset: 0x00103988
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 343776, XrefRangeEnd = 343782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializationException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializationException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035B4 RID: 13748 RVA: 0x001057C4 File Offset: 0x001039C4
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 343784, RefRangeEnd = 343812, XrefRangeStart = 343782, XrefRangeEnd = 343784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializationException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializationException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060035B5 RID: 13749 RVA: 0x00105810 File Offset: 0x00103A10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 343812, XrefRangeEnd = 343814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializationException(string message, Exception innerException)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializationException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerException);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035B6 RID: 13750 RVA: 0x00105870 File Offset: 0x00103A70
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 41353, RefRangeEnd = 41374, XrefRangeStart = 41353, XrefRangeEnd = 41374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializationException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializationException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060035B7 RID: 13751 RVA: 0x0001347B File Offset: 0x0001167B
		public SerializationException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CF0 RID: 3312
		// (get) Token: 0x060035B8 RID: 13752 RVA: 0x001058D4 File Offset: 0x00103AD4
		// (set) Token: 0x060035B9 RID: 13753 RVA: 0x00013484 File Offset: 0x00011684
		public unsafe static string _nullMessage
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SerializationException.NativeFieldInfoPtr__nullMessage, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SerializationException.NativeFieldInfoPtr__nullMessage, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04002D4F RID: 11599
		private static readonly IntPtr NativeFieldInfoPtr__nullMessage;

		// Token: 0x04002D50 RID: 11600
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002D51 RID: 11601
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04002D52 RID: 11602
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0;

		// Token: 0x04002D53 RID: 11603
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
