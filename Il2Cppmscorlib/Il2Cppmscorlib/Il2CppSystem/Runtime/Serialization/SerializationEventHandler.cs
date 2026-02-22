using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x02000327 RID: 807
	[Serializable]
	public sealed class SerializationEventHandler : MulticastDelegate
	{
		// Token: 0x06003443 RID: 13379 RVA: 0x000FFFEC File Offset: 0x000FE1EC
		// Note: this type is marked as 'beforefieldinit'.
		static SerializationEventHandler()
		{
			Il2CppClassPointerStore<SerializationEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "SerializationEventHandler");
			SerializationEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationEventHandler>.NativeClassPtr, 100671403);
			SerializationEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationEventHandler>.NativeClassPtr, 100671404);
		}

		// Token: 0x06003444 RID: 13380 RVA: 0x0010003C File Offset: 0x000FE23C
		[CallerCount(1135)]
		[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializationEventHandler(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializationEventHandler>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003445 RID: 13381 RVA: 0x00100098 File Offset: 0x000FE298
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 79689, RefRangeEnd = 79700, XrefRangeStart = 79689, XrefRangeEnd = 79700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke(StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003446 RID: 13382 RVA: 0x00012A48 File Offset: 0x00010C48
		public SerializationEventHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06003447 RID: 13383 RVA: 0x00012A51 File Offset: 0x00010C51
		public static implicit operator SerializationEventHandler(Action<StreamingContext> A_0)
		{
			return DelegateSupport.ConvertDelegate<SerializationEventHandler>(A_0);
		}

		// Token: 0x06003448 RID: 13384 RVA: 0x00012A59 File Offset: 0x00010C59
		public static SerializationEventHandler operator +(SerializationEventHandler A_0, SerializationEventHandler A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<SerializationEventHandler>();
		}

		// Token: 0x06003449 RID: 13385 RVA: 0x00012A67 File Offset: 0x00010C67
		public static SerializationEventHandler operator -(SerializationEventHandler A_0, SerializationEventHandler A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<SerializationEventHandler>();
			}
			return delegate2;
		}

		// Token: 0x04002C61 RID: 11361
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04002C62 RID: 11362
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_StreamingContext_0;
	}
}
