using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.Net.Sockets
{
	// Token: 0x02000132 RID: 306
	public static class SocketTaskExtensions : Object
	{
		// Token: 0x06001499 RID: 5273 RVA: 0x0000A662 File Offset: 0x00008862
		// Note: this type is marked as 'beforefieldinit'.
		static SocketTaskExtensions()
		{
			Il2CppClassPointerStore<SocketTaskExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Sockets", "SocketTaskExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SocketTaskExtensions>.NativeClassPtr);
			SocketTaskExtensions.NativeMethodInfoPtr_ConnectAsync_Public_Static_Task_Socket_EndPoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketTaskExtensions>.NativeClassPtr, 100666187);
		}

		// Token: 0x0600149A RID: 5274 RVA: 0x0005E1C4 File Offset: 0x0005C3C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 57288, RefRangeEnd = 57289, XrefRangeStart = 57248, XrefRangeEnd = 57288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task ConnectAsync(this Socket socket, EndPoint remoteEP)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(socket);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(remoteEP);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketTaskExtensions.NativeMethodInfoPtr_ConnectAsync_Public_Static_Task_Socket_EndPoint_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x0600149B RID: 5275 RVA: 0x0000A69B File Offset: 0x0000889B
		public SocketTaskExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040010A7 RID: 4263
		private static readonly IntPtr NativeMethodInfoPtr_ConnectAsync_Public_Static_Task_Socket_EndPoint_0;

		// Token: 0x020001F1 RID: 497
		[ObfuscatedName("System.Net.Sockets.SocketTaskExtensions+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001C12 RID: 7186 RVA: 0x000722BC File Offset: 0x000704BC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<SocketTaskExtensions.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SocketTaskExtensions>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SocketTaskExtensions.__c>.NativeClassPtr);
				SocketTaskExtensions.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketTaskExtensions.__c>.NativeClassPtr, "<>9");
				SocketTaskExtensions.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketTaskExtensions.__c>.NativeClassPtr, "<>9__2_0");
				SocketTaskExtensions.__c.NativeFieldInfoPtr___9__2_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketTaskExtensions.__c>.NativeClassPtr, "<>9__2_1");
				SocketTaskExtensions.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketTaskExtensions.__c>.NativeClassPtr, 100666189);
				SocketTaskExtensions.__c.NativeMethodInfoPtr__ConnectAsync_b__2_0_Internal_IAsyncResult_EndPoint_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketTaskExtensions.__c>.NativeClassPtr, 100666190);
				SocketTaskExtensions.__c.NativeMethodInfoPtr__ConnectAsync_b__2_1_Internal_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketTaskExtensions.__c>.NativeClassPtr, 100666191);
			}

			// Token: 0x06001C13 RID: 7187 RVA: 0x00072360 File Offset: 0x00070560
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SocketTaskExtensions.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketTaskExtensions.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001C14 RID: 7188 RVA: 0x0007239C File Offset: 0x0007059C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57235, XrefRangeEnd = 57240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult _ConnectAsync_b__2_0(EndPoint targetEndPoint, AsyncCallback callback, Object state)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetEndPoint);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketTaskExtensions.__c.NativeMethodInfoPtr__ConnectAsync_b__2_0_Internal_IAsyncResult_EndPoint_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06001C15 RID: 7189 RVA: 0x00072410 File Offset: 0x00070610
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 57240, XrefRangeEnd = 57248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ConnectAsync_b__2_1(IAsyncResult asyncResult)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SocketTaskExtensions.__c.NativeMethodInfoPtr__ConnectAsync_b__2_1_Internal_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001C16 RID: 7190 RVA: 0x0000FAF3 File Offset: 0x0000DCF3
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000912 RID: 2322
			// (get) Token: 0x06001C17 RID: 7191 RVA: 0x00072454 File Offset: 0x00070654
			// (set) Token: 0x06001C18 RID: 7192 RVA: 0x0000FAFC File Offset: 0x0000DCFC
			public unsafe static SocketTaskExtensions.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SocketTaskExtensions.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SocketTaskExtensions.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SocketTaskExtensions.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000913 RID: 2323
			// (get) Token: 0x06001C19 RID: 7193 RVA: 0x0007247C File Offset: 0x0007067C
			// (set) Token: 0x06001C1A RID: 7194 RVA: 0x0000FB0E File Offset: 0x0000DD0E
			public unsafe static Func<EndPoint, AsyncCallback, Object, IAsyncResult> __9__2_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SocketTaskExtensions.__c.NativeFieldInfoPtr___9__2_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<EndPoint, AsyncCallback, Object, IAsyncResult>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SocketTaskExtensions.__c.NativeFieldInfoPtr___9__2_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000914 RID: 2324
			// (get) Token: 0x06001C1B RID: 7195 RVA: 0x000724A4 File Offset: 0x000706A4
			// (set) Token: 0x06001C1C RID: 7196 RVA: 0x0000FB20 File Offset: 0x0000DD20
			public unsafe static Action<IAsyncResult> __9__2_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SocketTaskExtensions.__c.NativeFieldInfoPtr___9__2_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<IAsyncResult>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SocketTaskExtensions.__c.NativeFieldInfoPtr___9__2_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001556 RID: 5462
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001557 RID: 5463
			private static readonly IntPtr NativeFieldInfoPtr___9__2_0;

			// Token: 0x04001558 RID: 5464
			private static readonly IntPtr NativeFieldInfoPtr___9__2_1;

			// Token: 0x04001559 RID: 5465
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400155A RID: 5466
			private static readonly IntPtr NativeMethodInfoPtr__ConnectAsync_b__2_0_Internal_IAsyncResult_EndPoint_AsyncCallback_Object_0;

			// Token: 0x0400155B RID: 5467
			private static readonly IntPtr NativeMethodInfoPtr__ConnectAsync_b__2_1_Internal_Void_IAsyncResult_0;
		}
	}
}
