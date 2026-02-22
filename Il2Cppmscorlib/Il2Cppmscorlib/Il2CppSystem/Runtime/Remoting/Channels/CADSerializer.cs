using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.IO;
using Il2CppSystem.Runtime.Remoting.Messaging;

namespace Il2CppSystem.Runtime.Remoting.Channels
{
	// Token: 0x020003C6 RID: 966
	public class CADSerializer : Object
	{
		// Token: 0x06003E33 RID: 15923 RVA: 0x00122F24 File Offset: 0x00121124
		// Note: this type is marked as 'beforefieldinit'.
		static CADSerializer()
		{
			Il2CppClassPointerStore<CADSerializer>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Channels", "CADSerializer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CADSerializer>.NativeClassPtr);
			CADSerializer.NativeMethodInfoPtr_DeserializeMessage_Internal_Static_IMessage_MemoryStream_IMethodCallMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADSerializer>.NativeClassPtr, 100672442);
			CADSerializer.NativeMethodInfoPtr_SerializeMessage_Internal_Static_MemoryStream_IMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADSerializer>.NativeClassPtr, 100672443);
			CADSerializer.NativeMethodInfoPtr_DeserializeObjectSafe_Internal_Static_Object_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADSerializer>.NativeClassPtr, 100672444);
			CADSerializer.NativeMethodInfoPtr_SerializeObject_Internal_Static_MemoryStream_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADSerializer>.NativeClassPtr, 100672445);
			CADSerializer.NativeMethodInfoPtr_DeserializeObject_Internal_Static_Object_MemoryStream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADSerializer>.NativeClassPtr, 100672446);
		}

		// Token: 0x06003E34 RID: 15924 RVA: 0x00122FB8 File Offset: 0x001211B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 353547, RefRangeEnd = 353549, XrefRangeStart = 353542, XrefRangeEnd = 353547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IMessage DeserializeMessage(MemoryStream mem, IMethodCallMessage msg)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mem);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(msg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CADSerializer.NativeMethodInfoPtr_DeserializeMessage_Internal_Static_IMessage_MemoryStream_IMethodCallMessage_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessage>(intPtr3) : null;
		}

		// Token: 0x06003E35 RID: 15925 RVA: 0x00123010 File Offset: 0x00121210
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 353563, RefRangeEnd = 353565, XrefRangeStart = 353549, XrefRangeEnd = 353563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MemoryStream SerializeMessage(IMessage msg)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CADSerializer.NativeMethodInfoPtr_SerializeMessage_Internal_Static_MemoryStream_IMessage_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MemoryStream>(intPtr3) : null;
			}
		}

		// Token: 0x06003E36 RID: 15926 RVA: 0x00123054 File Offset: 0x00121254
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 353575, RefRangeEnd = 353576, XrefRangeStart = 353565, XrefRangeEnd = 353575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object DeserializeObjectSafe(Il2CppStructArray<byte> mem)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mem);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CADSerializer.NativeMethodInfoPtr_DeserializeObjectSafe_Internal_Static_Object_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06003E37 RID: 15927 RVA: 0x00123098 File Offset: 0x00121298
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 353590, RefRangeEnd = 353595, XrefRangeStart = 353576, XrefRangeEnd = 353590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MemoryStream SerializeObject(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CADSerializer.NativeMethodInfoPtr_SerializeObject_Internal_Static_MemoryStream_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MemoryStream>(intPtr3) : null;
			}
		}

		// Token: 0x06003E38 RID: 15928 RVA: 0x001230DC File Offset: 0x001212DC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 353601, RefRangeEnd = 353606, XrefRangeStart = 353595, XrefRangeEnd = 353601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object DeserializeObject(MemoryStream mem)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mem);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CADSerializer.NativeMethodInfoPtr_DeserializeObject_Internal_Static_Object_MemoryStream_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06003E39 RID: 15929 RVA: 0x000176D7 File Offset: 0x000158D7
		public CADSerializer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003356 RID: 13142
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeMessage_Internal_Static_IMessage_MemoryStream_IMethodCallMessage_0;

		// Token: 0x04003357 RID: 13143
		private static readonly IntPtr NativeMethodInfoPtr_SerializeMessage_Internal_Static_MemoryStream_IMessage_0;

		// Token: 0x04003358 RID: 13144
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeObjectSafe_Internal_Static_Object_Il2CppStructArray_1_Byte_0;

		// Token: 0x04003359 RID: 13145
		private static readonly IntPtr NativeMethodInfoPtr_SerializeObject_Internal_Static_MemoryStream_Object_0;

		// Token: 0x0400335A RID: 13146
		private static readonly IntPtr NativeMethodInfoPtr_DeserializeObject_Internal_Static_Object_MemoryStream_0;
	}
}
